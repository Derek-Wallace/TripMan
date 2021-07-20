using System.Data;
using Dapper;
using TripMan.Models;

namespace TripMan.Repositories
{
  public class VacationRepository
  {
    private readonly IDbConnection _db;

    public VacationRepository(IDbConnection db)
    {
      _db = db;
    }

    internal Cruise CreateCruise(Cruise c)
    {
      string sql = "INSERT INTO cruise(liner ,price, destination, passengers) VALUES (@Liner, @Price, @Destination, @Passengers) SELECT LAST_INSERT_ID();";
      c.Id = _db.ExecuteScalar<int>(sql, c);
      return c;
    }
    internal Trip CreateTrip(Trip t)
    {
      string sql = "INSERT INTO trip(price, destination) VALUES (@Price, @Destination) SELECT LAST_INSERT_ID();";
      t.Id = _db.ExecuteScalar<int>(sql, t);
      return t;
    }
  }
}