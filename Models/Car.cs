using System;
using System.Collections.Generic;

namespace Cars.Models
{
  public class Car
  {
    private static List<Car> _instances = new List<Car> {};

    private string _description;
    private string _model;
    private int _cost;
    private int _miles;


    public Car(string description, string model, int cost, int miles)
    {
      _description = description;
      _model = model;
      _cost = cost;
      _miles = miles;
    }

    public string GetDescription()
    {
      return _description;
    }

  public string GetModel()
    {
      return _model;
    }

    public int GetCost()
    {
      return _cost;
    }

    public int GetMiles()
      {
        return _miles;
      }

  public void Save()
  {
    _instances.Add(this);
  }
    public static List<Car> GetAll()
    {
      return _instances;
    }

    public static void Clear()
  {
    _instances.Clear();
  }
  }
}
