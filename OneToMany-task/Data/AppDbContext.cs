using System;
using Microsoft.EntityFrameworkCore;
using OneToMany_task.Models;

namespace OneToMany_task.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Slider> Sliders { get; set; }
        public DbSet<SliderInfo> SliderInfos { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Expert> Experts { get; set; }
        public DbSet<ExpertImage> ExpertImages { get; set; }
        public DbSet<Setting> Settings { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Blog>()
                        .HasData(
            new Blog
            {
                Id = 1,
                Title = "Title1",
                Description = "Desc1",
                Date = DateTime.Now,
                Image = "blog-feature-img-1.jpg"
            },

            new Blog
            {
                Id = 2,
                Title = "Title2",
                Description = "Desc2",
                Date = DateTime.Now,
                Image = "blog-feature-img-3.jpg"
            },

            new Blog
            {
                Id = 3,
                Title = "Title3",
                Description = "Desc3",
                Date = DateTime.Now,
                Image = "blog-feature-img-4.jpg"
            }
          );

           modelBuilder.Entity<Category>()
                       .HasData(
            new Category
            {
                Id = 1,
                Name ="Popular"
            },

            new Category
            {
                Id = 2,
                Name = "Winter"
            },

            new Category
            {
                Id = 3,
                Name = "Exotic"
            },

            new Category
            {
                Id = 4,
                Name = "Greens"
            },

            new Category
            {
                Id = 5,
                Name = "Cactus"
            },

            new Category
            {
                Id = 6,
                Name = "Rose"
            },

            new Category
            {
                Id = 7,
                Name = "Various"
            }
          );

            modelBuilder.Entity<ExpertImage>()
                        .HasData(
            new ExpertImage
            {
                Id = 1,
                Name = "instagram1.jpg"
            },

            new ExpertImage
            {
                Id = 2,
                Name = "instagram2.jpg"
            },

            new ExpertImage
            {
                Id = 3,
                Name = "instagram3.jpg"
            },

            new ExpertImage
            {
                Id = 4,
                Name = "instagram4.jpg"
            },

            new ExpertImage
            {
                Id = 5,
                Name = "instagram5.jpg"
            },

            new ExpertImage
            {
                Id = 6,
                Name = "instagram6.jpg"
            },

            new ExpertImage
            {
                Id = 7,
                Name = "instagram7.jpg"
            },

            new ExpertImage
            {
                Id = 8,
                Name = "instagram8.jpg"
            }
           );

            modelBuilder.Entity<Expert>()
                        .HasData(
            new Expert
            {
                Id = 1,
                Title = "testimonial-img-1.png",
                Description = "Nullam dictum felis eu pede mollis pretium. Integer tincidunt. Cras dapibus lingua.",
                Name = "Anna Barnes",
                Profession = "Florist"
            },

            new Expert
            {
                Id = 2,
                Title = "testimonial-img-2.png",
                Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo ligula eget.",
                Name = "asmine White",
                Profession = "Florist"
            }
          );

            modelBuilder.Entity<ProductImage>()
                        .HasData(
            new ProductImage
            {
                Id = 1,
                Name = "shop-13-img.jpg",
                ProductId = 1
            },

            new ProductImage
            {
                Id = 2,
                Name = "shop-7-img.jpg",
                ProductId = 3
            },

            new ProductImage
            {
                Id = 3,
                Name = "shop-9-img.jpg",
                ProductId = 2
            },

            new ProductImage
            {
                Id = 4,
                Name = "shop-11-img.jpg",
                ProductId = 4
            },

            new ProductImage
            {
                Id = 5,
                Name = "shop-8-img.jpg",
                ProductId = 11
            },

            new ProductImage
            {
                Id = 6,
                Name = "shop-7-img.jpg",
                ProductId = 6
            },

            new ProductImage
            {
                Id = 7,
                Name = "shop-9-img.jpg",
                ProductId = 5
            },

            new ProductImage
            {
                Id = 8,
                Name = "shop-7-img.jpg",
                ProductId = 7
            },

            new ProductImage
            {
                Id = 9,
                Name = "shop-11-img.jpg",
                ProductId = 8
            },

            new ProductImage
            {
                Id = 10,
                Name = "shop-12-img.jpg",
                ProductId = 9
            },

            new ProductImage
            {
                Id = 11,
                Name = "shop-13-img.jpg",
                ProductId = 8
            },

            new ProductImage
            {
                Id = 12,
                Name = "shop-13-img.jpg",
                ProductId = 10
            },

            new ProductImage
            {
                Id = 13,
                Name = "shop-9-img.jpg",
                ProductId = 13
            },

            new ProductImage
            {
                Id = 14,
                Name = "shop-7-img.jpg",
                ProductId = 12
            }
          );

            modelBuilder.Entity<Product>()
                        .HasData(
            new Product
            {
                Id = 1,
                Name = "Product1",
                Description = "desc1",
                Price = 250,
                CategoryId = 1
            },

            new Product
            {
                Id = 2,
                Name = "Product2",
                Description = "desc2",
                Price = 400,
                CategoryId = 2
            },

            new Product
            {
                Id = 3,
                Name = "Product3",
                Description = "desc3",
                Price = 450,
                CategoryId = 4
            },

            new Product
            {
                Id = 4,
                Name = "Product4",
                Description = "desc4",
                Price = 200,
                CategoryId = 3
            },

            new Product
            {
                Id = 5,
                Name = "Product5",
                Description = "desc5",
                Price = 150,
                CategoryId = 5
            },

            new Product
            {
                Id = 6,
                Name = "Product6",
                Description = "desc6",
                Price = 300,
                CategoryId = 7
            },

            new Product
            {
                Id = 7,
                Name = "Product7",
                Description = "desc7",
                Price = 305,
                CategoryId = 6
            },

            new Product
            {
                Id = 8,
                Name = "Product8",
                Description = "desc8",
                Price = 180,
                CategoryId = 6
            },

            new Product
            {
                Id = 9,
                Name = "Product9",
                Description = "desc9",
                Price = 500,
                CategoryId = 4
            },

            new Product
            {
                Id = 10,
                Name = "Product10",
                Description = "desc10",
                Price = 390,
                CategoryId = 2
            },

            new Product
            {
                Id = 11,
                Name = "Product11",
                Description = "desc11",
                Price = 110,
                CategoryId = 7
            },

            new Product
            {
                Id = 12,
                Name = "Product12",
                Description = "desc12",
                Price = 320,
                CategoryId = 7
            },

            new Product
            {
                Id = 13,
                Name = "Product13",
                Description = "desc13",
                Price = 340,
                CategoryId = 2
            }
          );

            modelBuilder.Entity<Setting>()
                        .HasData(
            new Setting
            {
                Id = 1,
                Key = "HeaderLogo",
                Value = "logo.png",
            },

            new Setting
            {
                Id = 2,
                Key = "4322525235",
                Value = "logo.png",
            },

            new Setting
            {
                Id = 3,
                Key = "Address",
                Value = "Ehmedli"
            }
          );

            modelBuilder.Entity<Slider>()
                        .HasData(
            new Slider
            {
                Id = 1,
                Image = "h3-slider-background.jpg"
            },

            new Slider
            {
                Id = 2,
                Image = "h3-slider-background-2.jpg"

            },

            new Slider
            {
                Id = 3,
                Image = "h3-slider-background-3.jpg"

            }
          );

            modelBuilder.Entity<SliderInfo>()
                        .HasData(
            new SliderInfo
            {
                Id = 1,
                Title = "<h1>Send <span>flowers</span> like</h1><h1>you mean it</h1>",
                Description = "Where flowers are our inspiration to create lasting memories. Whatever the occasion, our flowers will make it special cursus a sit amet mauris.",
                Signature = "h2 - sign - img.png"
            }
          );
        }
    }
}


