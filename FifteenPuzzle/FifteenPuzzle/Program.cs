using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FifteenPuzzle
{
    class Program
    {
        public static int[,] board;
        public static void ReadFromFile(string path)
        {
            string[] input = File.ReadAllLines(path);
            int a = 0, b = 0;
            int counter = 0;
            foreach (var row in input)
            {
                string[] numbers = row.Split(' ');
                if (counter == 0)
                {
                    a = Int32.Parse(numbers[0]);
                    b = Int32.Parse(numbers[1]);

                    board = new int[a, b];
                }
                else
                {
                    for (int i = 0; i < numbers.GetLength(0); i++)
                    {
                        board[counter - 1, i] = Int32.Parse(numbers[i]);
                    }
                }
                counter++;
            }

            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    Console.Write(board[i, j] + ", ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {

            ReadFromFile("poczatkowy.txt");
            //string x = sr.ReadLine();
            //Console.WriteLine(x);

            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //x = sr.ReadLine();
            //Console.WriteLine(x);



            //Frame.Initialize();
            Console.ReadKey();
        }
    }
}
