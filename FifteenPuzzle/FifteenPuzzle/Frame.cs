using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FifteenPuzzle
{
    public class Frame : ICloneable
    {
        public Puzzle[,] Board { get; set; }

        public Frame(int x, int y)
        {
            Board = new Puzzle[x, y];
        }

        private int Two2oneDim(int x, int y)
        {
            return 4 * x + y;
        }

        override public String ToString()
        {
            String s = "";
            for (int i = 0; i < this.Board.GetLength(0); i++)
            {
                for (int j = 0; j < this.Board.GetLength(1); j++)
                {
                    s += (this.Board[i, j].ToString() + ", ");
                }
                s += '\n';
            }
            return s;
        }

        public object Clone()
        {
            Frame f = new Frame(Board.GetLength(0), Board.GetLength(1))
            {
                Board = this.Board
            };
            return f;
        }

        public void MoveUp()
        {
            Coordinates c = FindEmpty();
            if (c.x > 0)
            {
                Puzzle p = Board[c.x, c.y];
                Board[c.x, c.y] = Board[c.x - 1, c.y];
                Board[c.x - 1, c.y] = p;
            }
            else
            {
                Console.WriteLine("nie mozna");
            }
        }

        public void MoveDown()
        {
            Coordinates c = FindEmpty();
            if (c.x < this.Board.GetLength(1) - 1)
            {
                Puzzle p = Board[c.x, c.y];
                Board[c.x, c.y] = Board[c.x + 1, c.y];
                Board[c.x + 1, c.y] = p;
            }
            else
            {
                Console.WriteLine("nie mozna");
            }
        }

        public void MoveRight()
        {
            Coordinates c = FindEmpty();
            if (c.y < this.Board.GetLength(0) - 1)
            {
                Puzzle p = Board[c.x, c.y];
                Board[c.x, c.y] = Board[c.x, c.y + 1];
                Board[c.x, c.y + 1] = p;
            }
            else
            {
                Console.WriteLine("nie mozna");
            }
        }

        public void MoveLeft()
        {
            Coordinates c = FindEmpty();
            if (c.y > 0)
            {
                Puzzle p = Board[c.x, c.y];
                Board[c.x, c.y] = Board[c.x, c.y - 1];
                Board[c.x, c.y - 1] = p;
            }
            else
            {
                Console.WriteLine("nie mozna");
            }
        }

        private Coordinates FindEmpty()
        {
            Coordinates c = null;
            for (int i = 0; i < this.Board.GetLength(0); i++)
            {
                for (int j = 0; j < this.Board.GetLength(1); j++)
                {
                    if (this.Board[i, j].Value == 0)
                    {
                        c = new Coordinates(i, j);
                    }
                }
            }
            return c;
        }
    }
}
