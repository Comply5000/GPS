using GPS.Entities;
using GPS.GPS;
using GPS.GPS.Commands;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GPS.Controllers;

[ApiController]
[Route("gps")]
public sealed class GPSController : Controller
{
    private readonly EFContext _context;

    public GPSController(EFContext context)
    {
        _context = context;
    }
    
    [HttpPost]
    public async Task<IActionResult> AddGpsData(AddGPSData request, CancellationToken cancellationToken)
    {
        var gpsData = new GPSData
        {
            Latitude = request.Latitude,
            Longitude = request.Longitude,
            CreatedAt = DateTimeOffset.UtcNow
        };

        await _context.AddAsync(gpsData, cancellationToken);
        await _context.SaveChangesAsync(cancellationToken);

        return Ok();
    }

    [HttpGet]
    public async Task<ActionResult<List<GPSData>>> GetGgsData(CancellationToken cancellationToken)
    {
        var gpsData = await _context.GpsDatas.AsNoTracking()
            .Select(x => new GPSData
            {
                Id = x.Id,
                Latitude = x.Latitude,
                Longitude = x.Longitude,
                CreatedAt = x.CreatedAt
            })
            .ToListAsync(cancellationToken);

        return Ok(gpsData);
    }
}
