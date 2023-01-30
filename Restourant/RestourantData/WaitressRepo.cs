using Google.Apis.Bigquery.v2.Data;
using Repository.Models;
using Table = Repository.Models.Table;

public class WaitressRepo
    {
     
        private List<Waitress> waitressList { get; }

        public WaitressRepo()
        {
            var waitressList = new List<Waitress>() {
                new Waitress { Id = 111, PinCode = 2233, Name = "Julija" },
                new Waitress { Id = 222, PinCode = 5522,Name = "Saule"},
                new Waitress { Id = 333, PinCode = 3253,Name = "Ramune"},
                new Waitress { Id = 444, PinCode = 2336,Name = "Adele"}
    }; 
    }

    public List<Waitress> RetrieveWaitressList()
        {
            return waitressList;
        }
        public Waitress RetrieveWaitress(int id, int passcode)
        {
            return waitressList.Find(waitress => waitress.Id == id && waitress.PinCode == passcode);
        }
    }
