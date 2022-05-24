using Microsoft.EntityFrameworkCore;
using Supermarket.Data;

namespace Supermarket.CRUD.ReadInstance
{
    public static class ReadProductWithCategory
    {
        public static void Read(DataContext context)
        {
            var items = context.Categories.AsNoTracking().Include(x => x.Products).ToList();
            foreach(var i in items)
            {
                Console.WriteLine(i.Name);
                foreach (var k in i.Products)
                    Console.WriteLine($"   Product Name: {k.Name} - Price: $ {k.Price}");
            }
            Console.ReadLine();
        }
    }
}