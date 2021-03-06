using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class PastryTests
  {

  }
}
public class PastryTests
  {

    [TestMethod]
    public void PastryConstructor_CreatesInstanceOfPastry_Pastry()
    {
      Pastry newPastry = new Pastry();
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }
  
    [TestMethod]
    public void GetNumPastries_ReturnsNumPastries_Int()
    {
    int numPastries = 5;
    Pastry newPastry = new Pastry(numPastries);
    int result = newPastry.numPastries;
    Assert.AreEqual(numPastries, result);
    }
    [TestMethod]
    public void CalculateSubTotal_ReturnsSubTotal_Int()
    {
      int numPastries = 5;
      Pastry newPastry = new Pastry(numPastries);
      int result = newPastry.CalculateSubTotal();
      Assert.AreEqual(7, result);
    }
  }

  
