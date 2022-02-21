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
            CreateMap<ProjectToAddDto,Project>();      
            CreateMap<InvoiceToAddDto,Invoice>();    
            CreateMap<ExecutionToAddDto,Execution>();  
            CreateMap<RiskToAddDto,Risk>();     
            CreateMap<ExpenseToAddDto,Expense>();     
            CreateMap<ExpenseToDelDto,Expense>();  
            CreateMap<ExpenseToUpdDto,Expense>();
            CreateMap<RiskToUpdDto,Risk>();
            CreateMap<ExecutionToUpdDto,Execution>();
            CreateMap<InvoiceToUpdDto,Invoice>();   
            CreateMap<ProjectToUpdDto,Project>();   
        }
    }
}