using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FifteenPuzzle
{
    public class Puzzle
    {
        public int Value { get; set; }                  //liczba naa kostce 
        public Coordinates MyCoordinates { get; set; }  //polozenie 



        public Puzzle(int val, int x, int y)
        {
            this.Value = val;
            this.MyCoordinates = new Coordinates(x, y);
        }
    }
}
