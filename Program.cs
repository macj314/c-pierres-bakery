using System;
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
      Console.WriteLine("console in pink", Color.Teal);
      Console.WriteLine(@"Hello! Welcome to Pierre's Bakery. We have a few choice items for sale:
Bread  $5   Sale: buy 2 get 1 free!
Pastry $2   Sale: buy 3 for $5", Color.Green);
      Console.WriteLine("How much bread would you like to purchase?");
      string bString = Console.ReadLine();
      if (!float.TryParse(bString, out float bInt)){bInt = 0;}
      Console.WriteLine("How many pastries would you like?");
      string pString = Console.ReadLine();
      if (!float.TryParse(pString, out float pInt)){pInt = 0;}
      float subTotal = bread.bPrice(bInt) + pastry.pPrice(pInt);
      float saleTax = subTotal * 0.07f, saleTotal = saleTax + subTotal, tip = saleTotal;
      tip = (float)System.Math.Round(saleTotal*.1,2);
      Console.WriteLine(@"+-------------------------------------+
|                                     |
|          Pierre's Bakery            |
|                                     |
|            Candy Lane               |
|         Seattle Washington          |
|           1-800(BAKED)              |
|                                     |
|  Bread                       $" + bread.bPrice(bInt) + @"    |
|  Pastry(ies)                 $" + pastry.pPrice(pInt) + @"     |
|                                     |
|  Subtotal                    $" + subTotal + @"    |
|                                     |
|  Tip | 10% $"+tip+ " | 15% $" +tip*.15+ " | 20% $"+tip*.2+@" |             |
|  TAX                         $" + saleTax + @"  |
|  TOTAL                       $" + saleTotal + @" |
|                                     |
|  Item Count: " + (bInt + pInt) +@"                      |
|                                     |
|             THANK YOU!              |
+-------------------------------------+");
      Console.WriteLine("1    2   3   4   5   6   7   8   9   10");
      string s = String.Format("First attempt Message: {0:C2}     |", subTotal);
      Console.WriteLine(s.PadLeft(39, ' '));
      Console.WriteLine(s);
    }
    
  }
}