using WebDeveloper.Model;

namespace WebDeveloper.DataAccess
{
    public class OrderData : BaseDataAccess<Orders>
    {
        public Orders GetOrderById(int? id)
        {
            using (var dbContext = new WebContextDb())
            {
                return dbContext.Orders.Find(id);
            }
        }
    }
}
