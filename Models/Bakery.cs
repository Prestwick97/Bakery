using System;
using System.Collections.Generic;

namespace Bakery.Models {
  public class Bread
  {
    public int Cost{get; set;}
    public int Quantity{get; set;}

    public Bread(int cost, int quantity)
    {
      Cost = cost;
      Quantity = quantity;
    }

    public void BuyBread(int quantity, int cost)
    {
      if (quantity == 1)
      {
        cost += 5;
      }
      for(int i = 0; i < quantity; i++)
      {
        if (i % 3 == 0)
        {
          cost +=10;
        }
      }
    }
  }
  public class Pastry
  {
    public int Cost{get; set;}
    public int Quantity{get; set;}

    public Pastry(int cost, int quantity)
    {
      Cost = cost;
      Quantity = quantity;
    }
    public void BuyPastry(int quantity, int cost)
    {
      for(int i = 0; i < quantity; i++)
      {
        if (i % 3 == 0)
        {
          cost +=5;
        }
        else
        {
          cost +=2;
        }
      }
    }
  }
}