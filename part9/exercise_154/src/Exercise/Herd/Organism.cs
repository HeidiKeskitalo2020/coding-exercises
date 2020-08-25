namespace Exercise
{
  public class Organism : IMovable
  {
    public int x {get; set;}
    public int y {get; set;}
    //private int dx;
    //private int dy;

    public Organism(int x, int y)
    {
      this.x = x;
      this.y = y;
    }
    public void Move(int dx, int dy)
    {
      this.x += dx;
      this.y += dy;
    }

    public override string ToString()
    {
      return "x: " + this.x + "; y: " + this.y;
    }
  }
}