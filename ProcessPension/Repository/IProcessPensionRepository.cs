using ProcessPension.Dtos;

namespace ProcessPension.Repository
{
    public interface IProcessPensionRepository
    {
        Task<PensionProcessDto> CalculatePension(string aadharNumber);
        Task<PensionProcessDto> StorePensioner(PensionProcessDto process);
    }
}
