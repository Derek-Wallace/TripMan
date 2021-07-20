using System;

namespace TripMan.Models
{
  public class Product
  {
    public int Id { get; set; }
    public string Name {get; set;}
    public int Price { get; set; }
    public int Quantity { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
  }
}