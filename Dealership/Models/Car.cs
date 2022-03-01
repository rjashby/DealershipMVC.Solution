using System.Collections.Generic;

namespace Dealership.Models
{
  public class Car
  {
  // Public auto-implemented properties
    public string MakeModel { get; set; }
    public string Year { get; set; }
    public string Price { get; set; }
    public string Miles { get; set; }
    private static List<Car> _instances = new List<Car> {};

    // Constructor
    public Car(string makeModel, string year, string price, string miles) 
    {
        Year = year;
        MakeModel = makeModel;
        Price = price;
        Miles = miles;
        _instances.Add(this);
    }

    public static List<Car> GetAll()
    {
      return _instances;
    }
  }
}