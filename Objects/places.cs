using System.Collections.Generic;

namespace Places.Objects
{
  public class Place
  {
    private string _city;
    private int _id;
    private static List<Place> _instances = new List<Place> {};

    public Place (string city)
    {
      _city = city;
      _instances.Add(this);
      _id = _instances.Count;
    }
    public string GetCity()
    {
      return _city;
    }
    public void SetCity(string newCity)
    {
      _city = newCity;
    }
    public int GetId()
    {
      return _id;
    }
    public static List<Place> GetAll()
    {
      return _instances;
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
    public static Place Find(int searchId)
    {
      return _instances[searchId-1];
    }
  }
}
