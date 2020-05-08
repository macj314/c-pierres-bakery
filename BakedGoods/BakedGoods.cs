namespace Bakery.BakedGoods
{
  public class Bread
  {
    public float BreadTotal { get; set; }
     public Bread(float breadTotal)
    {
      BreadTotal = breadTotal;
    }

    public float bPrice()
    {
      float bFree = (BreadTotal / 3) * 5;
      return (BreadTotal * 5) - bFree;
    }
  }
  public class Pastry
  {
    public float PastryTotal { get; set; }
     public Pastry(float pastryTotal)
    {
      PastryTotal = pastryTotal;
    }
    public float pPrice()
    {
      float pFree = (PastryTotal / 3);
      return (PastryTotal * 2) - pFree;
    }
  }
}