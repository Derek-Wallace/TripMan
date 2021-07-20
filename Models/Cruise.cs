using System;
using TripMan.Interfaces;

namespace TripMan.Models
{
  public class Cruise : IVacation
  {
    public int Id { get; set; }
    public int Price { get; set; }
    public string destination { get; set; }
    public string Liner { get; set; }
    public int Passengers { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
  }
}