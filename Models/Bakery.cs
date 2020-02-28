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
      Console.WriteLine("Wonderful! That will be $" + cost + " dollars!");
    }
  }
}
  // public class Bread
  // {
  //   public int Cost{get; set;}
  //   public int Quantity{get; set;}

  //   public Bread(int cost, int quantity)
  //   {
  //     Cost = cost;
  //     Quantity = quantity;
  //   }

  //   public void BuyBread(int quantity, int cost)
  //   {
  //     if (quantity == 1)
  //     {
  //       cost += 5;
  //     }
  //     for(int i = 0; i < quantity; i++)
  //     {
  //       if (i % 3 == 0)
  //       {
  //         cost +=10;
  //       }
  //     }
  //   }
  // }
  // public class Pastry
  // {
  //   public int Cost{get; set;}
  //   public int Quantity{get; set;}

  //   public Pastry(int cost, int quantity)
  //   {
  //     Cost = cost;
  //     Quantity = quantity;
  //   }
  //   public zBuyPastry(int quantity, int cost)
  //   {
  //     for(int i = 0; i < quantity; i++)
  //     {
  //       if (i % 3 == 0)
  //       {
  //         cost +=5;
  //       }
  //       else
  //       {
  //         cost +=2;
  //       }
  //     }
  //   }
  // }