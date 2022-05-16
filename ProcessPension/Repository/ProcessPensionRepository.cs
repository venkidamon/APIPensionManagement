using AutoMapper;
using ProcessPension.Data;
using ProcessPension.Dtos;
using ProcessPension.Entities;

namespace ProcessPension.Repository
{
    public class ProcessPensionRepository : IProcessPensionRepository
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public ProcessPensionRepository(DataContext context, IMapper mapper)
        {
            this._context = context;
            this._mapper = mapper;
        }

        public async Task<PensionProcessDto> CalculatePension(string aadharNumber)
        {
            try
            {
                AppProcessPension appPension = _context.appProcessPensions.SingleOrDefault(x => x.AadharNumber == aadharNumber);
                if(appPension != null)
                {
                    if(appPension.PensionType == "self")
                    {
                        appPension.Amount = (0.8 * appPension.Salary) + appPension.Allowance;
                    }
                    else
                    {
                        appPension.Amount = (0.5 * appPension.Salary) + appPension.Allowance;
                    }

                    if(appPension.BankType == "private")
                    {
                        appPension.BankServiceCharge = 550;
                    }
                    else
                    {
                        appPension.BankServiceCharge = 500;
                    }

                    _context.Update(appPension);
                    await _context.SaveChangesAsync();

                    return _mapper.Map<PensionProcessDto>(appPension);
                }
                return _mapper.Map<PensionProcessDto>(appPension);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<PensionProcessDto> StorePensioner(PensionProcessDto process)
        {

            AppProcessPension appProcessPension = _mapper.Map<AppProcessPension>(process);
            if (appProcessPension.Id > 0)
            {
                _context.appProcessPensions.Update(appProcessPension);
            }
            else
            {
                _context.appProcessPensions.Add(appProcessPension);
            }
            await _context.SaveChangesAsync();
            return _mapper.Map<PensionProcessDto>(appProcessPension);
        }
    }
}
