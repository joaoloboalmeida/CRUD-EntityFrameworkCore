using Supermarket.CRUD;
using Supermarket.CRUD.ReadInstance;
using Supermarket.Data;

namespace Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var context = new DataContext())
            {
                CreateInstance.Create(context);
                //UpdateInstance.Update(context);
                //ReadProducts.ReadAll(context);
                //ReadProducts.ReadById(context);
                //ReadCategories.ReadAll(context);
                //ReadCategories.ReadById(context);
                //ReadProductWithCategory.Read(context);
                //DeleteInstance.Delete(context);
            }
        }
    }
}