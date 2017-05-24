using Nancy;
using System.Collections.Generic;
using Places.Objects;

namespace Places
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };
      Get["/Places"] = _ => {
        return View["addPlace.cshtml"];
      };
      Post["/viewPlaces"] = _ => {
        Place newPlace = new Place(Request.Form["new-place"]);
        List<Place> allPlaces = Place.GetAll();
        return View["Places.cshtml", allPlaces];
      };
    }
  }
}
