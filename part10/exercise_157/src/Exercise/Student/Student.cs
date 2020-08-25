namespace Exercise
{
  using System;
  public class Student : IComparable<Student>
  {

    public string name { get; }

    public Student(string name)
    {
      this.name = name;
    }


    public override string ToString()
    {
      return name;
    }

    //BEGIN SOLUTION
    public int CompareTo(Student another)
    {
      return this.ToString().CompareTo(another.ToString());
      /* Tämä malli äy vain numeroita verrattaessa:
      if (another == null)
      {
        return 1;
      }
      if (this.name == another.name)
      {
        return 0;
      }
      else if (this.name > another.name)
      {
        return 1;
      }
      else
      { 
        return -1;
      }*/  
    }
    //END SOLUTION
  }
}