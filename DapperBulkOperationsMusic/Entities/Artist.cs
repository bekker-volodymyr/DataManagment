namespace DapperBulkOperationsMusic.Entities;
public class Artist
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Name { get; set; }
}