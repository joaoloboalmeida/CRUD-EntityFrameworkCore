using Supermarket.Data;
using Supermarket.Models;

namespace Supermarket.CRUD
{
    public static class CreateInstance
    {
        public static void Create(DataContext context)
        {
                var category = new Category(){ Name = "Fruits" };
                var category2 = new Category() { Name = "Alcoholic drinks" };

                var prod = new Product()
                {
                    Category = category,
                    Name = "Apple",
                    Price = 3.50m
                };
                
                var prod2 = new Product()
                {
                    Category = category2,
                    Name = "Budweiser Beer",
                    Price = 7.50m
                };

                var prod3 = new Product()
                {
                    Category = category2,
                    Name = "Black Label Scotch",
                    Price = 179.90m
                };

                var prod4 = new Product()
                {
                    Category = category,
                    Name = "Banana",
                    Price = 2.29m
                };

                context.Products.Add(prod);
                context.Products.Add(prod2);
                context.Products.Add(prod3);
                context.Products.Add(prod4);
                context.SaveChanges();
                Console.WriteLine("Successful insertions!");
                Console.ReadLine();
        }
    }
}