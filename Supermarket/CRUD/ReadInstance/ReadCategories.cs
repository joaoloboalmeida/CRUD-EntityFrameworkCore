using Microsoft.EntityFrameworkCore;
using Supermarket.Data;

namespace Supermarket.CRUD.ReadInstance
{
    public static class ReadCategories
    {
        public static void ReadAll(DataContext context)
        {
            var items = context.Categories.AsNoTracking().OrderBy(x => x.Id).ToList();
            foreach (var i in items)
                Console.WriteLine($"Category Id: {i.Id} - Name: {i.Name}");
            Console.ReadLine();
        }
        public static void ReadById(DataContext context)
        {
            var item = context.Categories.AsNoTracking().FirstOrDefault(x => x.Id == 2); //you can change the Id here
            Console.WriteLine($"Category Id: {item.Id} - Name: {item.Name}");
            Console.ReadLine();
        }
    }
}
