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
      else
      {
        for(int i = 0; i < quantity; i++)
        {
          if (i % 3 == 0)
          {
          cost += 10;
          }
        }
      }
      Console.WriteLine("Wonderful! That will be $" + cost + " dollars!");
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
      if (quantity == 1)
      {
        cost += 2;
      }
      else
      {
        for(int i = 0; i < quantity; i++)
        {
          if (i % 3 == 0)
          {
          cost += 5;
          }
        }
      }
      Console.WriteLine("`Excellent! That will be $" + cost + " dollars!`");
    }
  }
  public class Journey
  {
    public string Name{get; set;}

    public Journey(string name)
    {
      Name = name;
    }
    public void BeginJourney()
    {
      Console.WriteLine("You are now presented with a choise:");
      Console.WriteLine("*Take the food and run* (run)");
      Console.WriteLine("*Pay Pierre the baker for the food* (pay)");
      
    }
  }
}