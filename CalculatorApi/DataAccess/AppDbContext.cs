using CalculatorApi.Entities;
using Microsoft.EntityFrameworkCore;

namespace Api.DataAccess
{


        public class AppDbContext : DbContext
        {
            public DbSet<Calculations_2> calculations_2 { get; set; }


            public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
            {
            }

 

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
            modelBuilder
            .Entity<Calculations_2>(builder =>
            {
                builder.Property(f => f.id)
                .ValueGeneratedOnAdd();

                builder.HasKey(e => e.id);

                builder.ToTable("Calculations_2");

            });

        }
            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                if (!optionsBuilder.IsConfigured)
                {
                    IConfigurationRoot configuration = new ConfigurationBuilder()
                       .SetBasePath(Directory.GetCurrentDirectory())
                       .AddJsonFile("appsettings.json")
                       .Build();
                    var connectionString = "data source=.;initial catalog=MyNewDb;integrated security=true";
                optionsBuilder.UseSqlServer(connectionString);

            }
        }



        }

    }




