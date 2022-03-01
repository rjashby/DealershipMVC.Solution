using System.Collections.Generic;

namespace Dealership.Models
{
  public class Car
  {
  // Public auto-implemented properties
    public string MakeModel { get; set; }
    public int Year { get; set; }
    public int Price { get; set; }
    public int Miles { get; set; }
    private static List<Car> _instances = new List<Car> {};

    // Constructor
    public Car(string makeModel, int year, int price, int miles) 
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