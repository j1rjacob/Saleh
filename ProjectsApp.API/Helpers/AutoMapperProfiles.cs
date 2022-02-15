using AutoMapper;
using ProjectsApp.API.Models;

namespace ProjectsApp.API.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<User, UserForListDto>();
            CreateMap<User, UserForDetailedDto>();
            CreateMap<UserForRegisterDto, User>();                       
        }
    }
}