using BusinessObject.Objects;

namespace DataAccess.Repository
{
    public class OrderDetailRepository : IOrderDetailRepository
    {
        private FstoreContext _db;
        public OrderDetailRepository()
        {
            _db = new();
        }
        public void Add(Detail detail)
        {
            if(detail != null)
            {
                _db.Details.Add(detail);
                _db.SaveChanges();
            }
        }

        public void Add(Detail[] detail)
        {
            if(detail != null)
            {
                _db.AddRange(detail);
                _db.SaveChanges();
            }
        }

        public void Delete(Detail detail)
        {
                _db.Details.Remove(detail);
                _db.SaveChanges();
        }

        public IEnumerable<Detail> GetDetails() => _db.Details.ToList();

        public void Update(Detail detail)
        {
            if (detail != null)
            {
                _db.Details.Update(detail);
                _db.SaveChanges();
            }
        }

        public void Update(Detail[] detail)
        {
            if (detail != null)
            {
                _db.Details.UpdateRange(detail);
                _db.SaveChanges();
            }
        }
    }
}
