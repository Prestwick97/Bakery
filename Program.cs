using System;
using System.Collections.Generic;
using Bakery.Models;

class Program
{
  public static void Main()
  {
    Console.WriteLine("`Welcome to Pierre's Bakery! We have a choice between bread and pastries.`");
    Console.WriteLine("`At the moment, we have a special sale!`");
    Console.WriteLine("`Bread: Only $5 a loaf, but if you buy two, you get one free!`");
    Console.WriteLine("`Pastry: Only $2 a piece, but if you buy three, you get a dollar off!`");
    Console.WriteLine("`Would you like to buy bread, or pastry? (bread/pastry)`");
    string decision = Console.ReadLine();
    if (decision == "bread")
    {
      Console.WriteLine("`Wonderful! How many loaves of bread would you like? (Please enter a number quantity)`");
      string stringNumber = Console.ReadLine();
      int desiredQuantity = int.Parse(stringNumber);
      int cost = 0;
      Bread newBread = new Bread(cost, desiredQuantity);
      newBread.BuyBread(desiredQuantity, cost);
    }
    else
    {
      Console.WriteLine("`Wonderful! How many pastries would you like? (Please enter a number quantity)`");
      string stringNumber = Console.ReadLine();
      int desiredQuantity = int.Parse(stringNumber);
      int cost = 0;
      Pastry newPastry = new Pastry(cost, desiredQuantity);
      newPastry.BuyPastry(desiredQuantity, cost);
      
    }
  }
}