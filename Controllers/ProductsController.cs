using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TripMan.Models;
using TripMan.Services;

namespace TripMan.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class ProductsController : ControllerBase
  {
    private readonly ProductService _ps;

    public ProductsController(ProductService ps)
    {
      _ps = ps;
    }
    [HttpPost]
    public ActionResult<Product> CreateProduct([FromBody] Product p)
    {
      try
      {
          Product newP = _ps.CreateProduct(p);
          return newP;
      }
      catch (System.Exception e)
      {
          return BadRequest(e.Message);
      }
    }
    [HttpGet]
    public ActionResult<List<Product>> GetAll()
    {
      try
      {
        List<Product> Products = _ps.GetAll();
        return Ok(Products);
      }
      catch (System.Exception e)
      {
          return BadRequest(e.Message);
      }
    }
    [HttpPut("{id}")]
    public ActionResult<Product> Update(int id, [FromBody] Product p)
    {
      try
      {
          Product newP = _ps.Update(p);
          return Ok(newP);
      }
      catch (System.Exception e)
      {
          return BadRequest(e.Message);
      }
    }
    [HttpDelete("{id}")]
    public ActionResult<string> Remove(int id)
    {
      try
      {
          _ps.Remove(id);
          return Ok("Successfully Removed");
      }
      catch (System.Exception e)
      {
          return BadRequest(e.Message);
      }
    }
  }
}