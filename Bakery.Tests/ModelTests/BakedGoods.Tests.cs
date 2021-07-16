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

  }
}