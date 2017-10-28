using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FifteenPuzzle
{
    public class Puzzle :ICloneable
    {
        public int Value { get; set; }                  //liczba na kostce 
        public Coordinates MyCoordinates { get; set; }  //polozenie 
        public int myPlace;
        public int distance;


        public Puzzle(int val, int x, int y)
        {
            this.Value = val;
            this.myPlace = 4 * x + y;
            this.MyCoordinates = new Coordinates(x, y);
        }

        public void calculateDistance()
        {
            distance = myPlace - Value - 1;
        }
        override public String ToString()
        {
            return this.Value.ToString();
        }

        public object Clone()
        {          
            return new Puzzle(Value, MyCoordinates.x, MyCoordinates.y);
        }
    }
}
