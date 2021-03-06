using Microsoft.VisualStudio.TestTools.UnitTesting;
using BakedGoods.Models;

namespace BakedGoods.Tests
{
  [TestClass]
  public class BakeryTests
  {
    [TestMethod]
    public void PastryConstructor_CreatesInstanceOfPastry_True()
    {
      var newPastry = new Pastry();
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }

    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_True()
    {
      var newBread = new Bread();
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }

    [TestMethod]
    public void PastryCost_DeterminesRegPrice_Int()
    {
      int amount = 1;
      int willCost = 2;
      var pastryOrder = new Pastry();
      pastryOrder.PastryCost(amount);
      Assert.AreEqual(willCost, pastryOrder.PriceOfPastry);
    }

    [TestMethod]
    public void BreadCost_DeterminesRegPrice_Int()
    {
      int amount = 1;
      int willCost = 5;
      var breadOrder = new Bread();
      breadOrder.BreadCost(amount);
      Assert.AreEqual(willCost, breadOrder.PriceOfBread);
    }
    [TestMethod]
    public void PastryCost_PriceReflectingDiscount_Int()
    {
      int amount = 3;
      int willCost = 5;
      var pastryBulk = new Pastry();
      pastryBulk.PastryCost(amount);
      Assert.AreEqual(willCost, pastryBulk.PriceOfPastry);
    }

    [TestMethod]
    public void BreadCost_PriceReflectingDiscount_Int()
    {
      int amount = 3;
      int willCost = 10;
      var breadBulk = new Bread();
      breadBulk.BreadCost(amount);
      Assert.AreEqual(willCost, breadBulk.PriceOfBread);
    }
  }
}