using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

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
  }
}