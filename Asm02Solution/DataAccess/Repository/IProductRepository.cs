using BusinessObject.Objects;

namespace DataAccess.Repository;

public interface IProductRepository
{
    IEnumerable<Product> GetProducts();
    void AddProduct(Product product);
    void UpdateProduct(Product product);
    void DeleteProduct(Product product);
}
