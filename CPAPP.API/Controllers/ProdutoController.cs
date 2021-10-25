using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using CPAPP.Application.DTOs;
using CPAPP.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Distributed;
using Newtonsoft.Json;
using StackExchange.Redis;

namespace CPAPP.API.Controllers
{
    [ApiController]
    [Microsoft.AspNetCore.Components.Route("api/v1/")]
    public class ProdutoController : Controller
    {
        private readonly IProdutoService _produtoService;
        private readonly IDistributedCache _distributedCache;

        public ProdutoController(IProdutoService produtoService, IDistributedCache distributedCache)
        {
            _produtoService = produtoService;
            _distributedCache = distributedCache;
        }
        
        [HttpPost ("Post")]
        public async Task<ActionResult> Post([FromBody] ProdutoDTO produtoDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
        
            await _produtoService.CreateAsync(produtoDto);
        
            return new CreatedAtRouteResult("GetProduto",
                new { id = produtoDto.Id }, produtoDto);
        }
        
        [HttpGet("Get", Name = "Usando REDIS")]
        public async Task<ActionResult<IEnumerable<ProdutoDTO>>> Get()
        {
            var cacheKey = "orderList";
            string serializeOrderList;
            var orderList = new List<ProdutoDTO>();
            

            var redisOrderList = await _distributedCache.GetAsync(cacheKey);

            if (redisOrderList != null)
            {
                serializeOrderList = Encoding.UTF8.GetString(redisOrderList);
                orderList = JsonConvert.DeserializeObject<List<ProdutoDTO>>(serializeOrderList);
            }
            else
            {
                orderList = await _produtoService.GetProdutosAsync();
                serializeOrderList = JsonConvert.SerializeObject(orderList);
                redisOrderList = Encoding.UTF8.GetBytes(serializeOrderList);

                var options = new DistributedCacheEntryOptions().SetAbsoluteExpiration(DateTime.Now.AddMinutes(10))
                    .SetSlidingExpiration(TimeSpan.FromMinutes(2));

                await _distributedCache.SetAsync(cacheKey, redisOrderList, options);
            }
            
            //var produtos = await _produtoService.GetProdutosAsync();
            return Ok(orderList);
        }
    }
}