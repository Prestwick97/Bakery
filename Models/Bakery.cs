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
      Console.WriteLine("Pierre: `Wonderful! That will be $" + cost + " dollars!`");
      BeginQuest();
    }
    public void BeginQuest()
    {
      Console.WriteLine("* As you feel for your wallet, you realize you don't have any money. *");
      Console.WriteLine("------------------------------------------------");
      Console.WriteLine("** You are now presented with a choice:");
      Console.WriteLine("* Eat all the food you have in your hands as fast as you can. * (eat)");
      Console.WriteLine("* Confess to Pierre that you have no money. (confess)*");
      string eatConf = Console.ReadLine();
      if(eatConf == "eat")
      {
        Eat();
      }
      else
      {
        Console.WriteLine("* You confess to Pierre that you have no money to pay him. *");
        Console.WriteLine("Pierre: `Oh do not worry, my friend! Your honestly will take you far in life. Take the goods, on the house. ;)");
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
      Console.WriteLine("Pierre: `Excellent! That will be $" + cost + " dollars!`");
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
      else
      {
        Console.WriteLine("* You pay Pierre the money you owe him. *");
        Console.WriteLine("Pierre: `Thank you very much! You are a wonderful Customer! Please, come again. :-)");
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
        Console.WriteLine("Your hands are full of baked goods - you slam into the glass door with your elbow, completely shattering the door.");
      }
    }
  }
}