namespace Bakery.BakedGoods
{
  public class Bread
  {
    public int bPrice(int bTotal)
    {
      int bFree = (bTotal / 3) * 5;
      return (bTotal * 5) - bFree;
    }
  }
  public class Pastry
  {
    public int pPrice(int pTotal)
    {
      int pFree = (pTotal / 3);
      return (pTotal * 2) - pFree;
    }
  }
}