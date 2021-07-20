using System;
using TripMan.Interfaces;

namespace TripMan.Models
{
  public class Trip : IVacation
  {
    public int Id { get; set; }
    public int Price { get; set; }
    public string destination { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
  }
}