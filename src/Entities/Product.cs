using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sda_onsite_2_csharp_backend_teamwork.src
{
    public class Product
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }

        public Product(int id, int categoryId, string name, string description)
        {
            Id = id;
            CategoryId = categoryId;
            Name = name;
            Description = description;
        }
    }
}