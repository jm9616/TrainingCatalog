using AutoMapper;
using Onis.Catalog.ApplicationCore.DTOs;
using Onis.Domain.Entities;

namespace Onis.Catalog.Adapters
{
    public class CatalogItemAdapter : Profile
    {
        public CatalogItemAdapter()
        {
             //CreateMap<CatalogItemDTO, CatalogItem>().ReverseMap();
             CreateMap<CatalogItemDTO, CatalogItem>();
             CreateMap<CatalogItem,CatalogItemDTO>();

        }

    }

}
