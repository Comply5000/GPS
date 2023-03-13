using GPS.Entities;

namespace GPS.GPS;

public sealed class GPSDataDTO
{
    public Guid Id { get; set; }
    public double? Latitude { get; set; }
    public double? Longitude { get; set; }
    public DateTimeOffset CreatedAt { get; set; }

    public GPSDataDTO? Map(GPSData? gpsData)
    {
        if (gpsData is null) return null;

        Id = gpsData.Id;
        Latitude = gpsData.Latitude;
        Longitude = gpsData.Longitude;
        CreatedAt = gpsData.CreatedAt;

        return this;
    }
}