using System;

namespace aspnetcore_rest_api_with_dapper.Models
{
    public class Product
    {
        public long Id { get; set; }
        public long CategoryId { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}