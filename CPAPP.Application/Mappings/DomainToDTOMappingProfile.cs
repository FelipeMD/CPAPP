using AutoMapper;
using CPAPP.Application.DTOs;
using CPAPP.Domain.Entities;

namespace CPAPP.Application.Mappings
{
    public class DomainToDTOMappingProfile : Profile
    {
        public DomainToDTOMappingProfile()
        {
            CreateMap<Produto, ProdutoDTO>().ReverseMap();
        }
    }
}