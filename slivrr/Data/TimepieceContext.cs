using Microsoft.EntityFrameworkCore;
using slivrr.Models;

namespace slivrr.Data
{
    public class TimepieceContext : DbContext
    {
        public TimepieceContext(DbContextOptions<TimepieceContext> options)
            : base(options)
        { }

        public DbSet<Category> Categories { get; set; }
        public DbSet<CategoryToProduct> CategoriesToProducts { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CategoryToProduct>().HasKey(
                t => new { t.ProductId, t.CategoryId}
            );

            modelBuilder.Entity<Product>(
                p => {
                    p.HasKey( w => w.Id);
                    p.OwnsOne<Item>( w => w.Item, i => {
                        i.WithOwner(it => it.Product)
                            .HasForeignKey(it => it.Id);
                        i.Property(w => w.Price).HasColumnType("Money");
                        i.HasKey(w => w.Id);
                        i.HasData(
                            new Item
                            {
                                Id = 1,
                                Price = 8895.0M,
                                QuantityInStock = 5
                            },
                            new Item
                            {
                                Id = 2,
                                Price = 3360.0M,
                                QuantityInStock = 8
                            },
                            new Item
                            {
                                Id = 3,
                                Price = 17800.0M,
                                QuantityInStock = 1
                            },
                            new Item
                            {
                                Id = 4,
                                Price = 4300.0M,
                                QuantityInStock = 3
                            }
                        );
                    });
                }
            );

            modelBuilder.Entity<Category>().HasData(
                new Category {
                    Id = 1,
                    Name = "Tachymeter",
                    Description = "Used to compute a speed based on time."
                },
                new Category {
                    Id = 2,
                    Name = "Chronograph",
                    Description = "A stopwatch combined with a display watch."
                },
                new Category {
                    Id = 3,
                    Name = "Small Seconds",
                    Description = "A small second hand"
                },
                new Category {
                    Id = 4,
                    Name = "Manual Winding",
                    Description = "Manual winding of the timepiece"
                },
                new Category {
                    Id = 5,
                    Name = "Automatic Winding",
                    Description = "Automatic winding of the timepiece"
                }
            );

            modelBuilder.Entity<Product>().HasData(
                new Product {
                    Id = 1,
                    ItemId = 1,
                    Name = "Omega Speedmaster",
                    Description = "Dark Side of the Moon"
                },
                new Product {
                    Id = 2,
                    ItemId = 2,
                    Name = "TAG Heuer",
                    Description = "Carrera Calibre 16"
                },
                new Product {
                    Id = 3,
                    ItemId = 3,
                    Name = "Hublot Big Bang",
                    Description = "Unico Titanium 42mm"
                },
                new Product {
                    Id = 4,
                    ItemId = 4,
                    Name = "Bell & Ross",
                    Description = "BR V2-94 Garde-Cotes"
                }
            );

            modelBuilder.Entity<CategoryToProduct>().HasData(
                new CategoryToProduct { CategoryId = 1, ProductId = 1 },
                new CategoryToProduct { CategoryId = 2, ProductId = 1 },
                new CategoryToProduct { CategoryId = 3, ProductId = 1 },
                new CategoryToProduct { CategoryId = 4, ProductId = 1 },
                new CategoryToProduct { CategoryId = 1, ProductId = 2 },
                new CategoryToProduct { CategoryId = 2, ProductId = 2 },
                new CategoryToProduct { CategoryId = 3, ProductId = 2 },
                new CategoryToProduct { CategoryId = 5, ProductId = 2 },
                new CategoryToProduct { CategoryId = 2, ProductId = 3 },
                new CategoryToProduct { CategoryId = 5, ProductId = 3 },
                new CategoryToProduct { CategoryId = 2, ProductId = 4 },
                new CategoryToProduct { CategoryId = 5, ProductId = 4 }
            );
        }
    }
}
