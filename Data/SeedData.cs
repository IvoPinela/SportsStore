using SportsStore.Models;
namespace SportsStore.Data
{
    public static class SeedData
    {
        internal static void Populate(SportsStoreDbContext? db)
        {
            PopulateProducts(db);
        }

        private static void PopulateProducts(SportsStoreDbContext? db)
        {
            if (db.Products.Any())
            {
                return;
            }

            db.Products.AddRange(
                new Product { ProductName = "Kayak", ProductDescription = "A boat for one person", ProductCategory = "Watersports", ProductPrice = 275m },
                new Product { ProductName = "Lifejacket", ProductDescription = "Protective and fashionable", ProductCategory = "Watersports", ProductPrice = 48.95m },
                new Product { ProductName = "Soccer Ball", ProductDescription = "FIFA-approved size and weight", ProductCategory = "Soccer", ProductPrice = 19.50m },
                new Product { ProductName = "Corner Flags", ProductDescription = "Give your playing field a professional touch", ProductCategory = "Soccer", ProductPrice = 34.95m },
                new Product { ProductName = "Stadium", ProductDescription = "Flat-packed 35,000-seat stadium", ProductCategory = "Soccer", ProductPrice = 79500m },
                new Product { ProductName = "Thinking Cap", ProductDescription = "Improve brain efficiency by 75%", ProductCategory = "Chess", ProductPrice = 16m },
                new Product { ProductName = "Unsteady Chair", ProductDescription = "Secretly give your opponent a disadvantage", ProductCategory = "Chess", ProductPrice = 29.95m },
                new Product { ProductName = "Human Chess Board", ProductDescription = "A fun game for the family", ProductCategory = "Chess", ProductPrice = 75m },
                new Product { ProductName = "Bling-Bling King", ProductDescription = "Gold-plated, diamond-studded King", ProductCategory = "Chess", ProductPrice = 1200m }


                );
            db.SaveChanges();
        }
    }
}
