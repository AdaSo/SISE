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
        public static Frame ReadFromFile(string path )
        {
            string[] input = File.ReadAllLines(path);
            int a = 0, b = 0;
            int counter = 0;
            Frame frame = null;
            foreach (var row in input)
            {
                string[] numbers = row.Split(' ');
                if (counter == 0)
                {
                    a = Int32.Parse(numbers[0]);
                    b = Int32.Parse(numbers[1]);

                    frame = new Frame(a, b);
                }
                else
                {
                    for (int i = 0; i < numbers.GetLength(0); i++)
                    {
                        frame.Board[counter - 1, i] = new Puzzle(Int32.Parse(numbers[i]), counter - 1, i);
                    }
                }
                counter++;
            }

            //for (int i = 0; i < frame.Board.GetLength(0); i++)
            //{
            //    for (int j = 0; j < frame.Board.GetLength(1); j++)
            //    {
            //        Console.Write(frame.Board[i, j] + ", ");
            //    }
            //    Console.WriteLine();
            //}
            return frame;
        }
        static void Main(string[] args)
        {
            Frame frame = ReadFromFile("poczatkowy.txt");
            Console.WriteLine(  frame.ToString());
/*
            Console.WriteLine("w lewo:");
            frame.MoveLeft();
            Console.WriteLine(frame.ToString());

            Console.WriteLine("w lewo:");
            frame.MoveLeft();
            Console.WriteLine(frame.ToString());

            Console.WriteLine("w lewo:");

            frame.MoveLeft();
            Console.WriteLine(frame.ToString());

            Console.WriteLine("w lewo:");
            frame.MoveLeft();
            Console.WriteLine(frame.ToString());

            Console.WriteLine("w prawo:");
            frame.MoveRight();
            Console.WriteLine(frame.ToString());

            Console.WriteLine("w prawo:");
            frame.MoveRight();
            Console.WriteLine(frame.ToString());

            Console.WriteLine("w gore:");
            frame.MoveUp();
            Console.WriteLine(frame.ToString());

            Console.WriteLine("w gore:");
            frame.MoveUp();
            Console.WriteLine(frame.ToString());

            Console.WriteLine("w gore:");
            frame.MoveUp();
            Console.WriteLine(frame.ToString());

            Console.WriteLine("w dol:");
            frame.MoveDown();
            Console.WriteLine(frame.ToString());*/

            Solve.Initiate(frame);
            Solve.Solving(frame, 0);
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
