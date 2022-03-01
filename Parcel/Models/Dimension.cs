using System;
using System.Collections.Generic;

namespace Parcel.Models
{
  public class Dimension
  {
    public int Length{get;set;}
    public int Height { get; set; }
    public int Depth { get; set; }
    public int Weight{get;set;}
   //private static List<Parcel> _dimension = new List<Parcel> {};

    public Dimension(int length, int height, int depth, int weight)
    {
      Length = length;
      Height = height;
      Depth = depth;
      Weight = weight;
    //  _dimension.Add(this);
    }
// public static List<Item> GetAll()
//     {
//     return _instances;
//     }
    public  int Volume()
    {
      //Console.WriteLine(_dimension);
      int volume = (Length)*(Height)*(Depth);
      return volume;
    }

    public  int CostToShip()
    {
      int price = 0;
      int volume = Volume();
      if (volume <= 10) 
      {
        price = Weight*20;
      }
      else
      {
        price = Weight*30;
      }
      return price;
    }
  }
}