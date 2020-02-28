using System;
using System.Collections.Generic;

namespace Bakery.Models {
  private class Bread
  {
    private int Cost{get; set;}
    private int Quantity{get; set;}

    private Bread(int cost, int quantity)
    {
      Cost = cost;
      Quantity = quantity;
    }
    
  }
}