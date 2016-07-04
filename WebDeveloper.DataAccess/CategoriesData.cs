using System.Linq;
using WebDeveloper.Model;


namespace WebDeveloper.DataAccess
{
    public class CategoriesData : BaseDataAccess<Categories>
    {
        public Categories GetCategorytById(int? id)
        {
            using (var dbContext = new WebContextDb())
            {
                return dbContext.Categories.Find(id);
                //return dbContext.Categories.FirstOrDefault(s => s.CategoryID == id);
            }
        }
    }
}
