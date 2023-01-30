namespace Repository.Models
{
    public class Table
    {
        public int Id { get; set; }
        public int NumberOfSeats { get; set; }
        public bool Status { get; set; }

        public Table(int id, int numberOfSeats, bool status)
        {
            Id = id;
            NumberOfSeats = numberOfSeats;
            Status = status;
        }
        public Table()
        {
            var tableList = new List<Table>() {
                new Table { Id = 11, NumberOfSeats = 2,Status = true},
                new Table { Id = 22, NumberOfSeats = 5, Status = false},
                new Table { Id = 33, NumberOfSeats = 3,Status = true},
                new Table { Id = 44, NumberOfSeats = 4,Status = false}
    };
        }
    }
}