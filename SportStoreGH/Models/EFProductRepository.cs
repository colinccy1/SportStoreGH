using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportStoreGH.Models
{
    public class EFProductRepository:IProductRepository
    {
        private ApplicationDbcontext context;

        public EFProductRepository(ApplicationDbcontext ctx) { context = ctx; }

        public IEnumerable<Product> Products => context.Products;
    }
}
