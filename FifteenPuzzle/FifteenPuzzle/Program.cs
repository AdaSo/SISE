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
        public static void ReadFromFile(string path, Frame frame )
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

                    frame.Board = new int[a, b];
                }
                else
                {
                    for (int i = 0; i < numbers.GetLength(0); i++)
                    {
                        frame.Board[counter - 1, i] = Int32.Parse(numbers[i]);
                    }
                }
                counter++;
            }

            for (int i = 0; i < frame.Board.GetLength(0); i++)
            {
                for (int j = 0; j < frame.Board.GetLength(1); j++)
                {
                    Console.Write(frame.Board[i, j] + ", ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Frame frame = new Frame();

            ReadFromFile("poczatkowy.txt", frame);
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
