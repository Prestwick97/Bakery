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
      BeginJourney();
    }
    public void BeginJourney()
    {
      Console.WriteLine("** You are now presented with a choice:");
      Console.WriteLine("* Take the food and run * (run)");
      Console.WriteLine("* Pay Pierre the baker for the food * (pay)");
      string runPay = Console.ReadLine();
      if(runPay == "run")
      {
        Run();
      }
    }
    public void Run()
    {
      Console.WriteLine("*As you run to the door, you find that it's locked.*");
      Console.WriteLine("*You hear deviant laughter behind you.*");
      Console.WriteLine("** You are now presented with a choice: ");
      Console.WriteLine("* The door is glass, you may be able to break it if you try * (break");
      Console.WriteLine("* Turn around and confront Pierre (confront) *");
      string breakConfront = Console.ReadLine();
      if(breakConfront == "break")
      {
        Console.WriteLine("Your hands are full of baked good - you slam into the glass door with your elbow, completely shattering the door.");
      }
    }
  }
}