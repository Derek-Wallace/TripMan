using System.Collections.Generic;
using TripMan.Models;
using TripMan.Repositories;

namespace TripMan.Services
{
  public class ProductService
  {
    private readonly ProductRepository _pr;

    public ProductService(ProductRepository pr)
    {
      _pr = pr;
    }
    public Product CreateProduct(Product p)
    {
      return _pr.CreateProduct(p);
    }
    public List<Product> GetAll()
    {
      return _pr.GetAll();
    }
    public Product Update(Product p)
    {
      return _pr.Update(p);
    }
    public void Remove(int id)
    {
      _pr.Remove(id);
    }
  }
}