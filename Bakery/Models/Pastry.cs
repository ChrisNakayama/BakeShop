namespace Bakery.Models
{
  public class Pastry
  {
    public int NumPastries { get; }

    public Pastry(int pastries)
    {
      NumPastries = pastries;
    }

    public int CalculateSubTotal()
    {
      return 5;
    }
  }
}