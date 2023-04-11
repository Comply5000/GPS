namespace GPS.Entities;

public sealed class GPSData
{
    public Guid Id { get; set; }
    public double Latitude { get; set; }
    public double Longitude { get; set; }
    public DateTimeOffset CreatedAt { get; set; }
}