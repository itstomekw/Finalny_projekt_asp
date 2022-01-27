using CoffeeWave.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeWave.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Product> RecommendedProducts { get; set; }
    }
}
