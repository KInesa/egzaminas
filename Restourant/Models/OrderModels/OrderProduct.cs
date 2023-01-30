namespace Repository.Models.OrderModels
{
    public class OrderProduct
    {
        public Product Product { get; set; }


        public OrderProduct(Product product)
        {
            Product = product;

        }
    }
}