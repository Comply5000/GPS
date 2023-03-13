using GPS.Entities;
using Microsoft.AspNetCore.Authentication;
using Microsoft.EntityFrameworkCore;

namespace GPS;

public class EFContext : DbContext
{
    private readonly string _connectString =
        "Server=localhost;Database=GPS-database;User Id=postgres;Password=1qazXSW@;";
    
    public DbSet<GPSData> GpsDatas { get; set; }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql(_connectString);
    }
}