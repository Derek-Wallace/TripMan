using System;

namespace TripMan.Interfaces
{
  public interface IVacation
  {
    int Id { get; set; }
    int Price { get; set; }
    string destination { get; set; }
    DateTime CreatedAt { get; set; }
    DateTime UpdatedAt { get; set; }
  }
}