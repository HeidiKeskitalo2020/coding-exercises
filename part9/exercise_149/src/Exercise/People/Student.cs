namespace Exercise
{
  public class Student: Person
  {
    //private int credits;
    public int credits {get; set;}
    //private int credits;
    public Student(string name, string address) :
      base(name, address)
    {
      this.credits = credits;
    }    
    public void Study()
    {
      this.credits++;
    }

    public override string ToString()
    {
      return base.ToString() + " credits: " + this.credits;
    }
  }
}