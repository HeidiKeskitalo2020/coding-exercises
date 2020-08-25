namespace Exercise
{
  using System;
  using System.Collections.Generic;
  public class Herd : IMovable
  {
    public int x;
    public int y;
    public List<IMovable> list;
    public Herd()
    {
      //this.x = x;
      //this.y = y;
      this.list = new List<IMovable>();
    }

    public void AddToHerd(IMovable movable)
    {
      this.list.Add(movable);
    }

    public void Move(int dx, int dy)
    {
      foreach (IMovable movable in list)
      {
        movable.Move(dx, dy);
      }
    }

    public override string ToString()
    {
      string listPosition = "";
      foreach(IMovable movable in list)
      {
        listPosition += movable.ToString() + "\n";
      }
      return listPosition;
    }
  }
}