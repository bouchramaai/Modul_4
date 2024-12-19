using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using TodoProject.Data.Entities;

namespace TodoProject.Data;

public class ApplicationDbContext : DbContext
{
    public DbSet<UserEntity> Users { get; set; }
    public DbSet<AddressEntity> Addresses { get; set; }

    public DbSet <TodoEntity> Todos { get; set; }

    private static readonly ILoggerFactory _loggerFactory = LoggerFactory.Create((options) =>
    {
        options.AddDebug();
    });

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
     
        var dbPath = Path.Combine(@"F:\ASP.NET Core\TodoProject", "todo_project.db");

        optionsBuilder.UseSqlite($"Data Source={dbPath}")
            .EnableSensitiveDataLogging()
            .UseLoggerFactory(_loggerFactory);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<UserEntity>(entity =>
        {
            entity.ToTable("users");
            entity.Property(e => e.Id).HasColumnName("user Id");
            entity.Property(e => e.FirstName).HasColumnName("first Name");
            entity.Property(e => e.LastName).HasColumnName("last Name");
            entity.Property(e => e.Email).HasColumnName("email");
            entity.Property(e => e.AddressId).HasColumnName("address Id");
            entity.Property(e => e.SecondName).HasColumnName("second Name ");




        });

        modelBuilder.Entity<AddressEntity>(entity =>
        {
            entity.ToTable("addresses");
            entity.Property(e => e.Id).HasColumnName("address Id");
            entity.Property(e => e.Street).HasColumnName("street");
            entity.Property(e => e.City).HasColumnName("city");
            entity.Property(e => e.Country).HasColumnName("country");
            entity.Property(e => e.HouseNumber).HasColumnName("nr");
            entity.Property(e => e.ZipCode).HasColumnName("zipCode");
            


        });
    }
}
