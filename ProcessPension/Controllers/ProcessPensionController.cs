using Microsoft.AspNetCore.Mvc;
using ProcessPension.Dtos;
using ProcessPension.Repository;

namespace ProcessPension.Controllers
{
    [Route("api/ProcessPension")]
    public class ProcessPensionController : ControllerBase
    {
        private readonly IProcessPensionRepository _processPensionRepository;

        public ProcessPensionController(IProcessPensionRepository processPensionRepository)
        {
            _processPensionRepository = processPensionRepository;
        }
        [HttpGet]
        [Route("{aadharNumber}")]
        public async Task<PensionProcessDto> Get(string aadharNumber)
        {
            try
            {
                PensionProcessDto pension = await _processPensionRepository.CalculatePension(aadharNumber);
                return pension;
            }
            catch (Exception)
            {
                throw;
            }
        }
        [HttpPost]
        public async Task Post([FromBody] PensionProcessDto pensionProcessDto)
        {
            try
            {
                PensionProcessDto pension = await _processPensionRepository.StorePensioner(pensionProcessDto);
                /*return pension;*/
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
