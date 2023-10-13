using SportsStore.Models;

namespace SportsStore.Data
{
    public class FakeRepository : ISportsStoreRepository
    {
        public IEnumerable<Product> Products =>
            new List<Product>
            {
                new Product
                {
                    ProductName="Football ball",
                    ProductPrice= 25
                },

                new Product
                {
                    ProductName="SurfBoard",
                    ProductPrice= 375
                },

                new Product
                {
                    ProductName="Basketball ball",
                    ProductPrice= 45
                },

                new Product
                {
                    ProductName="Running Shoes",
                    ProductPrice= 95
                }
            };

    }
}
