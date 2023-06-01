using AutoMapper;
using Invoice.Control.Api.Requests;
using Invoice.Control.Domain.Entities;

namespace Invoice.Control.Api.Configurations.Automapper
{
    public class MapperProfile : Profile
    {
        public MapperProfile() 
        {
            CreateMap<CustomerRequestModel, Customer>().ReverseMap();
        } 
    }
}
