using AI_App.API.DTO;
using AI_App.API.Models;
using AutoMapper;

namespace AI_App.API.Mappings;

public class MappingProfile : Profile 
{
    public MappingProfile()
    {
        CreateMap<CreateOrEditCustomerDTO, Customer>().ReverseMap();
        CreateMap<Customer, CustomerDTO>().ReverseMap();
    }
}