using System.Collections.Generic;


namespace BakedGoods.Models
{
  public class Pastry
  {
    public int PriceOfPastry { get; set; }
    public void PastryCost(int amount)
    {

      PriceOfPastry = (amount * 2);
    }
  }

  public class Bread
  {
    public int PriceOfBread { get; set; }
  }
}
