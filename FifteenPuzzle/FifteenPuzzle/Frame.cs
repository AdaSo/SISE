using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FifteenPuzzle
{
    public class Frame
    {
        public int[,] Board { get; set; }

        public void Initialize()
        {
            Random rand = new Random(Guid.NewGuid().GetHashCode());

            Board = new int[4,4];
            Board[0, 0] = -1;
            for (int i = 0; i < Board.GetLength(0); i++)
            {
                for (int j = 0; j < Board.GetLength(1); j++)
                {
                    Board[i, j] = -1;
                }
            }

            int value = 0;
            int x_index;
            int y_index;
            while (value != 16)
            {
                 x_index = rand.Next(0, 4);
                 y_index = rand.Next(0, 4);

                if (Board[x_index, y_index] == -1)
                {
                    //Board.SetValue(value, x_index, y_index);
                    Board[x_index, y_index] = value;
                    value++;
                }
            }

            Console.WriteLine("Po inicjalizacji: ");
            for (int i = 0; i < Board.GetLength(0); i++)
            {
                for (int j = 0; j < Board.GetLength(1); j++)
                {
                    Console.Write(Board[i, j] + ", ");
                }
                Console.WriteLine();
            }
        }

        private int two2oneDim(int x, int y)
        {
            return 4 * x + y;
        }
    }
}
