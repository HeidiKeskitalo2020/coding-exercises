namespace Exercise
{
  public class Person
  {
    /*public string name {get; set;}
    public string address {get; set;}*/
    private string name;
    private string address;
    public Person(string name, string address)
    {
      this.name = name;
      this.address = address;
    }
    public override string ToString()
    {
      return this.name + ", " + this.address;
    }
  }
}
