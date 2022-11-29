using AutoMapper;
using TestVisionAPI.Models;

namespace TestVisionAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<TestDetailsDto, TestDetails>();
                config.CreateMap<TestDetails, TestDetailsDto>();
            });

            return mappingConfig;
        }
    }
}
