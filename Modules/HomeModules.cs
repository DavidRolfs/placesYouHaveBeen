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
      Get["/viewPlaces"] = _ => {
        List<Place> allPlaces = Place.GetAll();
        return View["Places.cshtml", allPlaces];
      };
      Get["/viewPlaces/{id}"] = parameters => {
      Place place = Place.Find(parameters.id);
        return View["/place.cshtml", place];
      };
      Post["/places_cleared"] = _ => {
        Place.ClearAll();
        return View["/cleared.cshtml"];
      };
    }
  }
}
