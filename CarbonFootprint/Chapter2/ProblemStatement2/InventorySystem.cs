namespace Chapter2.ProblemStatement2
{
    public class InventorySystem
    {
        private List<Product> products;

        public InventorySystem()
        {
            products = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public List<Product> GetInventoryProducts()
        {
            return products;
        }
    }
}
