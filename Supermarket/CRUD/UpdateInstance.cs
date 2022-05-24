using Supermarket.Data;

namespace Supermarket.CRUD
{
    public static class UpdateInstance
    {
        public static void Update(DataContext context)
        {
           var up = context.Products.FirstOrDefault(x => x.Name.Contains("Apple"));
           up.Price = 3.49m;

            var up2 = context.Products.FirstOrDefault(x => x.Id == 2);
            up2.Name = "Heineken Beer";
            up2.Price = 9.99m;

            context.Products.Update(up);
            context.Products.Update(up2);
            context.SaveChanges();
            Console.WriteLine("Update successful!");
            Console.ReadLine();
        }
    }
}