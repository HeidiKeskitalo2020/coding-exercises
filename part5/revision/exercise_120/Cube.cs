using System;
namespace exercise_120
{
    public class Cube
    {
        private int volume = 0;
        private int edgeLength = 0;
        public Cube (int edgeLength)
        {
            this.edgeLength = edgeLength;
        }
        public int Volume()
        {
            this.volume = edgeLength * edgeLength * edgeLength;
            return volume;
        }
        public override string ToString()
        {
          return "The length of the edge is " + edgeLength + " and the volume " + Volume(); 
        }
    }
}