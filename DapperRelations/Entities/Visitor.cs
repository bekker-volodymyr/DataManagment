namespace DapperRelations.Entities
{
    public class Visitor
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;
        public string PhoneNumber { get; set; } = default!;
        public DateTime DateOfBirth { get; set; }

        public Passport? Passport { get; set; }
    }
}