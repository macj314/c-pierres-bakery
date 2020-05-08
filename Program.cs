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
      Console.WriteLine(@"Hello! Welcome to Pierre's Bakery. We have a few choice items for sale:
Bread  $5   Sale: buy 2 get 1 free!
Pastry $2   Sale: buy 3 for $5", Color.Pink);

      //Collect data from user and get prices for entered values
      Console.WriteLine("How much bread would you like to purchase?");
      string bString = Console.ReadLine();
      if (!float.TryParse(bString, out float bFloat)){bFloat = 0;}
      Bread bread = new Bread(bFloat);
      Console.WriteLine("How many pastries would you like?");
      string pString = Console.ReadLine();
      if (!float.TryParse(pString, out float pFloat)){pFloat = 0;}
      Pastry pastry = new Pastry(pFloat);

      //Convert prices into various floats for display purposes in a console receipt
      float subTotal = bread.bPrice() + pastry.pPrice();
      float saleTax = subTotal * 0.07f, saleTotal = saleTax + subTotal, tip = saleTotal;
      tip = (float)System.Math.Round(saleTotal*.2f,2);

      //Instantiate Dictionary object with strings and numbers to display
      Dictionary<string, float> receipt = new Dictionary<string, float>()
      {
        {"Pierre's Bakery", 0},
        {"Candy Lane", 0},
        {"Seattle Washington", 0},
        {"1-800-BAKE", 0},
        {"Bread", bread.bPrice()},
        {"Pastry", pastry.pPrice()},
        {"Subtotal", subTotal},
        {"Tax", saleTax},
        {"Total", saleTotal},
        {"Tip", tip},
        {"Item Count", (bFloat+pFloat)},
        {"THANK YOU", 0}
      };
      
      //Loop through Dictionary object and print out elements
      Console.WriteLine("+-------------------------------------+");
      for (int i = 0; i < receipt.Count; i++)
      {
        if (receipt[ receipt.Keys.ElementAt(i)] == 0)
        {       
          string a = String.Format("|{0,25}             |", receipt.Keys.ElementAt(i));
          Console.WriteLine(a);
        } else
        {
          string a = String.Format("|{0,-10}{1,28:C2}|", receipt.Keys.ElementAt(i), receipt[ receipt.Keys.ElementAt(i)]);
          Console.WriteLine(a);
        }
      }
      Console.WriteLine("+-------------------------------------+");
    }  
  }
}