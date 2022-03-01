using System;

namespace Parcel.Models
{
  public class Parcel
  {
    public int Length{get;set;}
    public int Height { get; set }
    public int Depth { get; set }
    public int Weight{get;set;}
    public Parcel(int length, int height, int depth, int weight)
    {
      Length = length;
      Height = height;
      Depth = depth;
      Weight = weight;
    }

    public int Volume()
    {
      int volume = (Length*Height*Depth);
      return volume;
    }

    public int CostToShip()
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