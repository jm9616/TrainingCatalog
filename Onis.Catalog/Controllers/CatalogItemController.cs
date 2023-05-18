using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Onis.Catalog.ApplicationCore.DTOs;
using Onis.Domain.Contracts;
using Onis.Domain.Entities;

namespace Onis.Catalog.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatalogItemController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ICatalogItemRepository _repo;
        public CatalogItemController(ICatalogItemRepository repo, IMapper mapper)
        {
            _mapper = mapper;
            _repo = repo;
        }
        [HttpPost]
        public async Task<IActionResult> AddCatalogItem(CatalogItemDTO dto)
        {
            var CatalogItem = _mapper.Map<CatalogItem>(dto);
            // Call repo actions, return catalog item entity with ID
            return Ok(CatalogItem);
        }
    }
}
