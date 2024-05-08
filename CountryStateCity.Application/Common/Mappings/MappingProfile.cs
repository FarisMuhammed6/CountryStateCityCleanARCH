using AutoMapper;
using CountryStateCity.Application.CountryStateCity.city;
using CountryStateCity.Application.CountryStateCity.country;
using CountryStateCity.Application.CountryStateCity.state;
using CountryStateCity.Domain.DTOS.AllList;
using CountryStateCity.Domain.Entities;


namespace CountryStateCity.Application.Common.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
           /* CreateMap<City, CityDTO>().ReverseMap();
            CreateMap<State, StateDTO>().ReverseMap();
            CreateMap<Country, StateDTO>().ReverseMap();
            CreateMap<City, CityDTO2>().ReverseMap();
            CreateMap<State, StateDTO2>().ReverseMap();*/

            CreateMap<City, CityDTO>().ReverseMap();
            CreateMap<State, StateDTO>().ReverseMap();
            CreateMap<Country, CountryDTO>().ReverseMap();
            CreateMap<City, CityDTO2>().ReverseMap();
            CreateMap<State, StateDTO2>().ReverseMap();


        }
        /*public MappingProfile()
        {
            ApplyMappingsFromAssembly(Assembly.GetExecutingAssembly());
        }

        private void ApplyMappingsFromAssembly(Assembly assembly)
        {
            var mapFromType = typeof(IMapFrom<>);
            var mappingMethodName = nameof(IMapFrom<object>.Mapping);
            bool HashInterface(Type t) => t.IsGenericType && t.GetGenericTypeDefinition() == mapFromType;
            var types = assembly.GetExportedTypes().Where(t => t.GetInterfaces().Any(HashInterface)).ToList();
            var ARGUMENTtYPES = new Type[] { typeof(Profile) };
            foreach (var type in types)
            {
                var instance = Activator.CreateInstance(type);
                var methodInfo = type.GetMethod(mappingMethodName);
                if (methodInfo != null)
                {
                    methodInfo.Invoke(instance, new object[] { this });

                }
                else
                {
                    var interfaces = type.GetInterfaces().Where(HashInterface).ToList();
                    if (interfaces.Count > 0)
                    {
                        foreach (var @interface in interfaces)
                        {
                            var interfaceMethodInfo = @interface.GetMethod(mappingMethodName, ARGUMENTtYPES);
                            interfaceMethodInfo?.Invoke(instance, new object[] { this });
                        }
                    }
                }
            }
        }*/

    }
}
