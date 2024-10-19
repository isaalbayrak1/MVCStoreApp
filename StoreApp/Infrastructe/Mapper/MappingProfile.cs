using AutoMapper;
using Entities.DTO;
using Entities.Models;

namespace StoreApp.Infrastructe.Mapper;

public class MappingProfile:Profile
{
    public MappingProfile() 
    {
        CreateMap<ProductDtoForInsertion, Product>();
        CreateMap<ProductDtoForUpdate, Product>().ReverseMap();
    }
}
