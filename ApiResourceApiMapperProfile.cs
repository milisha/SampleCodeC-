using AutoMapper;
using binovi.connect.Admin.Api.Dtos.ApiResources;
using Skoruba.IdentityServer4.Admin.BusinessLogic.Dtos.Configuration;

namespace binovi.connect.Admin.Api.Mappers
{
    public class ApiResourceApiMapperProfile : Profile
    {
        public ApiResourceApiMapperProfile()
        {
            // binovi.connect.api Resources
            CreateMap<ApiResourcesDto, ApiResourcesApiDto>(MemberList.Destination)
                .ReverseMap();

            CreateMap<ApiResourceDto, ApiResourceApiDto>(MemberList.Destination)
                .ReverseMap();

            // binovi.connect.api Scopes
            CreateMap<ApiScopesDto, ApiScopesApiDto>(MemberList.Destination)
                .ReverseMap();

            CreateMap<ApiScopeDto, ApiScopeApiDto>(MemberList.Destination)
                .ReverseMap();
            
            CreateMap<ApiScopesDto, ApiScopeApiDto>(MemberList.Destination)
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.ApiScopeId))
                .ReverseMap();

            // binovi.connect.api Secrets
            CreateMap<ApiSecretsDto, ApiSecretApiDto>(MemberList.Destination)
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.ApiSecretId))
                .ReverseMap();

            CreateMap<ApiSecretDto, ApiSecretApiDto>(MemberList.Destination);
            CreateMap<ApiSecretsDto, ApiSecretsApiDto>(MemberList.Destination);

            // binovi.connect.api Properties
            CreateMap<ApiResourcePropertiesDto, ApiResourcePropertyApiDto>(MemberList.Destination)
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.ApiResourcePropertyId))
                .ReverseMap();

            CreateMap<ApiResourcePropertyDto, ApiResourcePropertyApiDto>(MemberList.Destination);
            CreateMap<ApiResourcePropertiesDto, ApiResourcePropertiesApiDto>(MemberList.Destination);
        }
    }
}





