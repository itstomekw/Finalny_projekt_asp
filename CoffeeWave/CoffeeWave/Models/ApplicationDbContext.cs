using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeWave.Models
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(new Category
            {
                CategoryId=1,
                Name="Coffee",
            });

            modelBuilder.Entity<Category>().HasData(new Category
            {
                CategoryId = 2,
                Name = "Tea",
            });

            modelBuilder.Entity<Category>().HasData(new Category
            {
                CategoryId = 3,
                Name = "Yerba Mate",
            });

            modelBuilder.Entity<Category>().HasData(new Category
            {
                CategoryId = 4,
                Name = "Accessories",
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id =1,
                Name = "Figa Coffee - Gwatemala La Bolsa",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque sollicitudin ornare sem, eu dapibus libero lobortis at. Proin felis libero, mollis quis aliquam interdum, gravida id sem. ",
                Brand= "Figa Coffee",
                Price =45.99M,
                ImageUrl= "https://cdn.pixabay.com/photo/2020/08/04/09/18/coffee-5462272_960_720.jpg",
                InStock=true,
                Recommended=true,
                CategoryId=1,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 2,
                Name = "Rocket Bean - Kenya Ruka Chui",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque sollicitudin ornare sem, eu dapibus libero lobortis at. Proin felis libero, mollis quis aliquam interdum, gravida id sem. ",
                Brand = "Rocket Bean",
                Price =49.99M,
                ImageUrl = "https://cdn.pixabay.com/photo/2020/08/04/09/18/coffee-5462272_960_720.jpg",
                InStock = true,
                Recommended = false,
                CategoryId = 1,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 3,
                Name = "Autumn Coffee - Brazylia Colibri Santos Espresso",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque sollicitudin ornare sem, eu dapibus libero lobortis at. Proin felis libero, mollis quis aliquam interdum, gravida id sem. ",
                Brand = "Autumn Coffee",
                Price =56.99M,
                ImageUrl = "https://cdn.pixabay.com/photo/2020/08/04/09/18/coffee-5462272_960_720.jpg",
                InStock = true,
                Recommended = false,
                CategoryId = 1,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 4,
                Name = "Pure Ceylon",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque sollicitudin ornare sem, eu dapibus libero lobortis at. Proin felis libero, mollis quis aliquam interdum, gravida id sem. ",
                Brand = "BingoTwingo",
                Price =15.99M,
                ImageUrl = "https://cdn.pixabay.com/photo/2015/07/02/10/44/tea-828940_960_720.jpg",
                InStock = true,
                Recommended = false,
                CategoryId = 2,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 5,
                Name = "Earl Grey Strong",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque sollicitudin ornare sem, eu dapibus libero lobortis at. Proin felis libero, mollis quis aliquam interdum, gravida id sem. ",
                Brand = "BingoTwingo",
                Price =12.99M,
                ImageUrl = "https://cdn.pixabay.com/photo/2015/07/02/10/44/tea-828940_960_720.jpg",
                InStock = true,
                Recommended = false,
                CategoryId = 2,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 6,
                Name = "English Breakfast",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque sollicitudin ornare sem, eu dapibus libero lobortis at. Proin felis libero, mollis quis aliquam interdum, gravida id sem. ",
                Brand = "BingoTwingo",
                Price =24.99M,
                ImageUrl = "https://cdn.pixabay.com/photo/2015/07/02/10/44/tea-828940_960_720.jpg",
                InStock = true,
                Recommended = false,
                CategoryId = 2,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 7,
                Name = "Amanda Despalada",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque sollicitudin ornare sem, eu dapibus libero lobortis at. Proin felis libero, mollis quis aliquam interdum, gravida id sem. ",
                Brand = "Amanda",
                Price =11.99M,
                ImageUrl = "https://cdn.pixabay.com/photo/2017/06/24/17/00/yerba-mate-2438196_960_720.jpg",
                InStock = true,
                Recommended = false,
                CategoryId = 3,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 8,
                Name = "Pajarito Seleccion Especial",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque sollicitudin ornare sem, eu dapibus libero lobortis at. Proin felis libero, mollis quis aliquam interdum, gravida id sem. ",
                Brand = "Pajarito",
                Price =19.99M,
                ImageUrl = "https://cdn.pixabay.com/photo/2017/06/24/17/00/yerba-mate-2438196_960_720.jpg",
                InStock = true,
                Recommended = false,
                CategoryId = 3,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 9,
                Name = "Cruz de Malta - Classic",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque sollicitudin ornare sem, eu dapibus libero lobortis at. Proin felis libero, mollis quis aliquam interdum, gravida id sem. ",
                Brand = "Cruz de Malta",
                Price =19.99M,
                ImageUrl = "https://cdn.pixabay.com/photo/2017/06/24/17/00/yerba-mate-2438196_960_720.jpg",
                InStock = true,
                Recommended = false,
                CategoryId = 3,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 10,
                Name = "Matero",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque sollicitudin ornare sem, eu dapibus libero lobortis at. Proin felis libero, mollis quis aliquam interdum, gravida id sem. ",
                Brand = "BestasMateras",
                Price =12.99M,
                ImageUrl = "https://cdn.pixabay.com/photo/2017/06/24/17/02/yerba-mate-2438200_960_720.jpg",
                InStock = true,
                Recommended = false,
                CategoryId = 4,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 11,
                Name = "Kettle and cups",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque sollicitudin ornare sem, eu dapibus libero lobortis at. Proin felis libero, mollis quis aliquam interdum, gravida id sem. ",
                Brand = "NicuPor Ce Lanes",
                Price =95.99M,
                ImageUrl = "https://cdn.pixabay.com/photo/2016/05/01/05/38/kettle-1364454_960_720.jpg",
                InStock = true,
                Recommended = true,
                CategoryId = 4,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 12,
                Name = "Coffee Scale",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque sollicitudin ornare sem, eu dapibus libero lobortis at. Proin felis libero, mollis quis aliquam interdum, gravida id sem. ",
                Brand = "PoorHarius",
                Price = 69.99M,
                ImageUrl = "https://cdn.pixabay.com/photo/2013/12/31/16/18/horizontal-236899_960_720.jpg",
                InStock = true,
                Recommended = false,
                CategoryId = 4,
            });
        }
    }
}
