namespace Exercise
{
  using System;
  public class Human : IComparable<Human>
  {

    public int wage { get; }
    public string name { get; }

    public Human(string name, int wage)
    {
      this.name = name;
      this.wage = wage;
    }
    
    public int CompareTo(Human another)
    {
      if (another == null)
      {
        return 1;
      }
      if (this.wage == another.wage)
      {
        return 0;
      }
      else if (this.wage > another.wage)
      {
        return -1;
      }
      else
      {
        return 1;
      }
      /*if (this.name == another.name)
      {
        return this.Wage().CompareTo(another.Wage());
      }
      return this.name.CompareTo(another.name);*/
      // BEGIN SOLUTION
              //return 0;
      // END SOLUTION
    }
    


    public override string ToString()
    {
      return this.name + " " + this.wage;
    }
  }
}