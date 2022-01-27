using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeWave.Models
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;
        public ProductRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public IEnumerable<Product> AllProducts
        {
            get
            {
                return _applicationDbContext.Products.Include(c => c.Category);
            }
        }

        public IEnumerable<Product> RecommendedProducts
        {
            get
            {
                return _applicationDbContext.Products.Include(c => c.Category).Where(p => p.Recommended);
            }
        }

        public Product GetProductById(int productId)
        {
            return _applicationDbContext.Products.FirstOrDefault(p => p.Id == productId);
        }
    }
}
