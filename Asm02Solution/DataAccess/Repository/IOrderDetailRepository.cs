using BusinessObject.Objects;

namespace DataAccess.Repository;

public interface IOrderDetailRepository
{
    IEnumerable<Detail> GetDetails();
    void Add(Detail detail);
    void Add(Detail[] detail);
    void Update(Detail detail);
    void Update(Detail[] detail);
    void Delete(Detail detail);
}
