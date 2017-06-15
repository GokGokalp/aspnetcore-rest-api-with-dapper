using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aspnetcore_rest_api_with_dapper.Business;
using aspnetcore_rest_api_with_dapper.Contracts;
using aspnetcore_rest_api_with_dapper.Data;
using aspnetcore_rest_api_with_dapper.Models;
using Microsoft.AspNetCore.Mvc;

namespace aspnetcore_rest_api_with_dapper.Controllers
{
    [Route("api/v1/[controller]")]
    public class ProductsController : Controller
    {
        private readonly IProductBusiness _productBusiness;

        public ProductsController(IProductBusiness productBusiness)
        {
            _productBusiness = productBusiness;
        }

        // GET api/v1/products/{id}
        [HttpGet("{id}")]
        public async Task<ProductResponse> Get(long id)
        {
            return await _productBusiness.GetAsync(id);
        }

        // GET api/v1/products
        [HttpGet]
        public async Task<ProductResponse> Get()
        {
            return await _productBusiness.GetAllAsync();
        }

        // POST api/v1/products
        [ProducesResponseType(201)]
        [HttpPost]
        public async Task Post([FromBody]ProductRequest productRequest)
        {
            await _productBusiness.AddAsync(productRequest);
        }
    }
}