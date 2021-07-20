using Microsoft.AspNetCore.Mvc;
using TripMan.Models;
using TripMan.Services;

namespace TripMan.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class VacationController : ControllerBase
  {
    private readonly VacationService _vs;

    public VacationController(VacationService vs)
    {
      _vs = vs;
    }
    [HttpPost]
    public ActionResult<Cruise> CreateCruise([FromBody] Cruise c)
    {
      try
      {
          Cruise newC = _vs.CreateCruise(c);
          return newC;
      }
      catch (System.Exception e)
      {
          return BadRequest(e.Message);
      }
    }
    [HttpPost]
    public ActionResult<Trip> CreateTrip([FromBody] Trip t)
    {
      try
      {
          Trip newT = _vs.CreateTrip(t);
          return newT;
      }
      catch (System.Exception e)
      {
          return BadRequest(e.Message);
      }
    }
  }
}