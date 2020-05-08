namespace Bakery.BakedGoods
{
  public class Bread
  {
    public float bPrice(float bTotal)
    {
      float bFree = (bTotal / 3) * 5;
      return (bTotal * 5) - bFree;
    }
  }
  public class Pastry
  {
    public float pPrice(float pTotal)
    {
      float pFree = (pTotal / 3);
      return (pTotal * 2) - pFree;
    }
  }
}