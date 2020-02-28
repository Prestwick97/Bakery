using System;
using System.Collections.Generic;
using Bakery.Models;

class Program
{
  public static void Main()
  {
    Console.WriteLine("Welcome to Pierre's Bakery! We have a choice between bread and pastries.");
    Console.WriteLine("At the moment, we have a special sale! Bread is only $5 a loaf, but if you buy two, you get one free!    .....   How many loafs would you like to purchase?");
    string stringNumber = Console.ReadLine();
    int desiredQuantity = int.Parse(stringNumber);
    int cost = 0;
    Bread newBread = new Bread(cost, desiredQuantity);
    newBread.BuyBread(desiredQuantity, cost);
  }
}
    // Console.WriteLine("You have a choice");
    // string stringNumber = Console.ReadLine();
    // int quantity = int.Parse(stringNumber);
    // int cost = 0;
    // Bread newBread = new Bread(cost, quantity);
    // newBread.BuyBread(quantity, cost);
    // Console.WriteLine(quantity);
    // Console.WriteLine(cost);