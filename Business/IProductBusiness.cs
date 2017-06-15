using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using aspnetcore_rest_api_with_dapper.Contracts;
using aspnetcore_rest_api_with_dapper.Models;

namespace aspnetcore_rest_api_with_dapper.Business
{
    public interface IProductBusiness
    {
        Task<ProductResponse> GetAsync(long id);
        Task<ProductResponse> GetAllAsync();
        Task AddAsync(ProductRequest productRequest);
    }
}