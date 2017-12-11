using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportStoreGH.Models
{
    public class FakeProductRepository:IProductRepository
    {
        public IEnumerable<Product> Products => new List<Product>
        {
            new Product {Name="Football",Price=25,Description="1"},
            new Product {Name="Surf board",Price=179,Description="2"},
            new Product {Name="Running shoes",Price=95,Description="3"}
        };
    }
}
