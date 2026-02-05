using Microsoft.EntityFrameworkCore;
using MovieApi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApi.Persistence.Context
{
    public class MovieContext : DbContext
    /*Bu kullanım, .NET dünyasında Entity Framework Core (EF Core) kütüphanesinin temel taşını oluşturur. 
     * DbContext sınıfından miras alan MovieContext sınıfı, uygulamanız ile veritabanı arasındaki köprüdür.*/
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Veritabanı bağlantı dizesi burada belirtilir.
            optionsBuilder.UseSqlServer("Server=DESKTOP-MBOHETQ\\SQLEXPRESS;initial Catalog=ApiMovieDb;" +
                "integrated Security=true;" +
                "TrustServerCertificate=true");


        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Cast> Casts { get; set; }
    }
}
