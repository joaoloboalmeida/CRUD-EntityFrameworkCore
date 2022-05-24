using Microsoft.EntityFrameworkCore;
using Supermarket.Data;

namespace Supermarket.CRUD.ReadInstance
{
    public static class ReadProducts
    {
        public static void ReadAll(DataContext context)
        {
            var items = context.Products.AsNoTracking().ToList();
            foreach (var i in items)
                Console.WriteLine($"Name: {i.Name} - Price: $ {i.Price}");
            Console.ReadLine();
        }
        public static void ReadById(DataContext context)
        {
            var item = context.Products.AsNoTracking().FirstOrDefault(x => x.Id == 3); //you can change the Id here
            Console.WriteLine($"Name: {item.Name} - Price: $ {item.Price}");
            Console.ReadLine();
        }
    }
}