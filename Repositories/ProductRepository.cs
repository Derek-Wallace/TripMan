using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dapper;
using TripMan.Models;

namespace TripMan.Repositories
{
  public class ProductRepository
  {
    private readonly IDbConnection _db;

    public ProductRepository(IDbConnection db)
    {
      _db = db;
    }
    internal Product CreateProduct(Product p)
    {
      string sql = @"
      INSERT INTO products(name, price, quantity)
      VALUES (@Name, @Price, @Quantity);
      SELECT LAST_INSERT_ID();
      ";
      p.Id = _db.ExecuteScalar<int>(sql, p);
      return p;
    }

    internal List<Product> GetAll()
    {
      var sql = "SELECT * FROM products";
      return _db.Query<Product>(sql).ToList();
    }

    internal Product Update(Product p)
    {
      string sql = @"
      UPDATE products
      SET
      name = @Name,
      quantity = @Quantity
      WHERE id = @Id;
      ";
      _db.Execute(sql, p);
      return p;
    }
    internal void Remove(int id)
    {
      string sql = "DELETE FROM products WHERE id = @id LIMIT 1;";
      _db.Execute(sql, new { id });
    }
  }
}