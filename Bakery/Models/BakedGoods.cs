using System.Collections.Generic;


namespace BakedGoods.Models
{
  public class Pastry
  {
    public int PriceOfPastry { get; set; }
    public void PastryCost(int amount)
    {
      if (amount >= 3)
      {
        int dealNum = (amount / 3);
        int singleNum = (amount % 3);
        PriceOfPastry = (dealNum * 5) + (singleNum * 2);
      }
      else
      {
        PriceOfPastry = (amount * 2);
      }
    }
  }



  public class Bread
  {
    public int PriceOfBread { get; set; }
    public void BreadCost(int amount)
    {
      if (amount >= 3)
      {
        int dealNum = (amount / 3);
        int singleNum = (amount % 3);
        PriceOfBread = (dealNum * 10) + (singleNum * 5);
      }
      else
      {
        PriceOfBread = (amount * 5);
      }
    }
  }
}



