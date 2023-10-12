namespace CarsAPI
{
    public record CarDTO(Guid ID, string Name, string Desc, DateTime Created);
    public record CreateCarDTO(string Name, string Desc);
    public record UpdateCarDTO(string Name, string Desc);
    public record DeleteCarDTO(Guid ID);
}
