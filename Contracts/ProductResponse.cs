using System;
using System.Collections.Generic;
using aspnetcore_rest_api_with_dapper.Models;
using Newtonsoft.Json;

namespace aspnetcore_rest_api_with_dapper.Contracts
{
    public class ProductResponse
    {
        public ProductResponse()
        {  
             Products = new List<Product>();
        }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Message { get; set; }

        public List<Product> Products { get; set; }
    }
}