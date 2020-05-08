using System;
using System.Drawing;
using System.Linq;
using System.Collections.Generic;
using Console = Colorful.Console;
using Bakery.BakedGoods;

namespace Bakery
{
  public class Program
  {
    public static void Main()
    {      
      Console.WriteLine("console in pink", Color.Teal);
      Console.WriteLine(@"Hello! Welcome to Pierre's Bakery. We have a few choice items for sale:
Bread  $5   Sale: buy 2 get 1 free!
Pastry $2   Sale: buy 3 for $5", Color.Green);
      Console.WriteLine("How much bread would you like to purchase?");

      string bString = Console.ReadLine();
      if (!float.TryParse(bString, out float bFloat)){bFloat = 0;}
      Bread bread = new Bread(bFloat);
      Console.WriteLine("How many pastries would you like?");
      string pString = Console.ReadLine();
      if (!float.TryParse(pString, out float pFloat)){pFloat = 0;}
      Pastry pastry = new Pastry(pFloat);

      float subTotal = bread.bPrice() + pastry.pPrice();
      float saleTax = subTotal * 0.07f, saleTotal = saleTax + subTotal, tip = saleTotal;
      tip = (float)System.Math.Round(saleTotal*.1,2);

      Dictionary<string, float> receipt = new Dictionary<string, float>()
      {
        {"Pierre's Bakery", 0},
        {"Candy Lane", 0},
        {"Seattke Washington", 0},
        {"1-800-BAKED", 0},
        {"Bread", bread.bPrice()},
        {"Pastry", pastry.pPrice()},
        {"Subtotal", subTotal},
        {"Tax", saleTax},
        {"Tip", tip},
        {"Total", saleTotal},
        {"Item Count", (bFloat+pFloat)},
        {"THANK YOU", 0}
      };
      Console.WriteLine("+-------------------------------------+");
      for (int i = 0; i < receipt.Count; i++)
      {
        if (receipt[ receipt.Keys.ElementAt(i)] == 0)
        {       
          string a = String.Format("|   {0}", receipt.Keys.ElementAt(i));
          Console.WriteLine(a);
        } else
        {
          string a = String.Format("|   {0:}        {1:C2}", receipt.Keys.ElementAt(i), receipt[ receipt.Keys.ElementAt(i)]);
          Console.WriteLine(a);
        }
      }
      Console.WriteLine("+-------------------------------------+");
      Console.WriteLine("1    2   3   4   5   6   7   8   9   10");
      // string s = String.Format("First attempt Message: {0:C2}     |", subTotal);
      // Console.WriteLine(s.PadLeft(39, ' '));
      // Console.WriteLine(s);
    }
    
  }
}