using TripMan.Models;
using TripMan.Repositories;

namespace TripMan.Services
{
  public class VacationService
  {
    private readonly VacationRepository _vp;

    public VacationService(VacationRepository vp)
    {
      _vp = vp;
    }
    public Cruise CreateCruise(Cruise c)
    {
      return _vp.CreateCruise(c);
    }
    public Trip CreateTrip(Trip t)
    {
      return _vp.CreateTrip(t);
    }
  }
}