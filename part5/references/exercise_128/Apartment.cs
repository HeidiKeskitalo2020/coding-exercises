namespace exercise_128
{

  using System;
  public class Apartment
  {

    private int rooms;
    private int squares;
    private int pricePerSquare;

    public Apartment(int rooms, int squares, int pricePerSquare)
    {
      this.rooms = rooms;
      this.squares = squares;
      this.pricePerSquare = pricePerSquare;
    }

    public bool LargerThan(Apartment compared)
    {
      
      if (rooms < compared.rooms )
      {
        return true;
      }
      return false;
    }

    private int Price()
    {
      
      return this.squares * pricePerSquare; 
      
    }

    public int PriceDifference(Apartment compared)
    {
      //if (pricePerSquare < compared.pricePerSquare)
      //{
        //return compared.pricePerSquare;
      //}
      // Math.Abs returns the absolute value
      return Math.Abs ((compared.squares * compared.pricePerSquare) - (this.squares * this.pricePerSquare));
    }

    public bool MoreExpensiveThan(Apartment compared)
    {
      if (this.Price() > compared.Price())
      {
        return true;
      }
      return false;
    }
  }
}
