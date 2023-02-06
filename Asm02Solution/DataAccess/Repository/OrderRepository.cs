using BusinessObject.Objects;

namespace DataAccess.Repository
{
    public class OrderRepository : IOrderRepository
    {
        private readonly FstoreContext _db;
        public OrderRepository()
        {
            _db = new();
        }
        public void AddOrder(Order order)
        {
            if(order != null)
            {
                _db.Orders.Add(order);
                _db.SaveChanges();
            }
        }

        public void DeleteOrder(Order order)
        {
                _db.Orders.Remove(order);
                _db.SaveChanges();
        }

        public IEnumerable<Order> GetOrders() => _db.Orders.ToList();

        public void UpdateOrder(Order order)
        {
            if (order != null)
            {
                _db.Orders.Update(order);
                _db.SaveChanges();
            }
        }
    }
}
