using AutoMapper;
using ProcessPension.Dtos;
using ProcessPension.Entities;

namespace ProcessPension
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<PensionProcessDto, AppProcessPension>();
                config.CreateMap<AppProcessPension, PensionProcessDto>();

            });
            return mappingConfig;
        } 
    }
}
