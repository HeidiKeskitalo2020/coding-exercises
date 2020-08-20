namespace Exercise
{
  public class Teacher: Person
  {
    //public string name {get; set;}
    //public string address {get; set;}
    public int salary {get; set;}
    public Teacher(string name, string address, int salary) :
      base(name, address)
    {
      this.salary = salary;
    }    
    public override string ToString()
    {
      return base.ToString() + " salary " + this.salary + " per month";
    }
  }
}