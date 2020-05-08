using System;
using System.Collections.Generic;
using System.Drawing;
using Console = Colorful.Console;
using Bakery.BakedGoods;

namespace Bakery
{
  public class Program
  {
    public static void Main()
    {
      Bread bread = new Bread();
      Pastry pastry = new Pastry();
      Console.WriteLine(@"Hello! Welcome to Pierre's Bakery. We have a few choice items for sale:
Bread  $5   Sale: buy 2 get 1 free!
Pastry $2   Sale: buy 3 for $5", Color.Green);
      Console.WriteLine("How much bread would you like to purchase?");
      string bString = Console.ReadLine();
      if (int.TryParse(bString, out int bInt))
      {
      } else {bInt = 0;}
      Console.WriteLine("How many pastries would you like?");
      string pString = Console.ReadLine();
      if (int.TryParse(pString, out int pInt))
      {
      } else {pInt = 0;}
      Console.WriteLine("Bread: " + bread.bPrice(bInt) + " Pastries: " + pastry.pPrice(pInt));
    }
  }
}