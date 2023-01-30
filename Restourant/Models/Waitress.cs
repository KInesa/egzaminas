namespace Repository.Models
{
    public class Waitress
    {
        public int Id { get; set; }
        public int PinCode { get; set; }
        public string Name { get; set; }

        public List<Table> TableList { get; set; }

        public Waitress(int id, int pinCode, string name, List<Table> tableList)
        {
            Id = id;
            PinCode = pinCode;
            Name = name;
            TableList = tableList;
        }

        public Waitress()
        {
        }
    }
}