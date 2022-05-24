using Supermarket.Data;

namespace Supermarket.CRUD
{
    public static class DeleteInstance
    {
        public static void Delete(DataContext context)
        {
            var del = context.Products.FirstOrDefault(x => x.Id == 4);
            var del2 = context.Categories.FirstOrDefault(x => x.Id == 2);

            context.Products.Remove(del);
            context.Categories.Remove(del2);
            context.SaveChanges();
            Console.WriteLine("Delete successful!");
            Console.ReadLine();
        }
    }
}