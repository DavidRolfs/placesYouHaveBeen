using System.Collections.Generic;

namespace Places.Objects
{
  public class Place
  {
    private string _city;
    private string _photo;
    private int _id;
    private static List<Place> _instances = new List<Place> {};

    public Place (string city, string photo)
    {
      _city = city;
      _photo = photo;
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
    public string GetPhoto()
    {
      return _photo;
    }
    public void SetPhoto(string newPhoto)
    {
      _photo = newPhoto;
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
