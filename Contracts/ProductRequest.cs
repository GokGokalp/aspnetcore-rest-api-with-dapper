using System;
using System.Collections.Generic;

namespace aspnetcore_rest_api_with_dapper.Contracts
{
    public class ProductRequest
    {
        public long CategoryId { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
    }
}