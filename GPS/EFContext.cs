using GPS.Entities;
using Microsoft.AspNetCore.Authentication;
using Microsoft.EntityFrameworkCore;

namespace GPS;

public class EFContext : DbContext
{
    public EFContext() : base()
    {
        
    }
    
    public EFContext(DbContextOptions<EFContext> options) : base(options)
    {
        
    }
    
    public DbSet<GPSData> GpsDatas { get; set; }
    
}