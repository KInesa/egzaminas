using Repository.Models;
using Repository.Models.OrderModels;

namespace Repository.DataAccess
{
    public class ProductRepo
    {
        List<Product> retrevieData = new List<Product>();

        public List<Product> RetrevieData()
        {
            var dataFile = File.ReadAllLines(@"Meniu.docx")
                .Skip(1)
                .Select(x => x.Split(','))
                .Select(x => new Food(
                    x[0],
                    x[1],
                    decimal.Parse(x[3])
                )).ToList();
            retrevieData.AddRange(dataFile);
            return retrevieData;
        }
    }
}