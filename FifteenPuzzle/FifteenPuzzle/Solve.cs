using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FifteenPuzzle
{
    public static class Solve
    {
        public static Frame f; 

        public static void Initiate(Frame frame)
        {
            Console.WriteLine("wygenerowana poprawna: ");
            f = GenerateCorrectFrame(frame);
        }
        public static bool Solving(Frame frame, int direction ) //0-up, 1-down, 2-roght, 3-left
        {
            
            
            Console.WriteLine(frame.ToString());
            if (frame == f)
            {
                Console.WriteLine("koniec");
                return true;
            }
            else
            {
                if(frame.MoveUp())
                {
                    Solve.Solving(frame, 0);
                }
                        
                else if (frame.MoveDown())
                {
                    Solve.Solving(frame, 1);

                }
                        
                else if(frame.MoveRight())
                {
                    Solve.Solving(frame, 2);

                }
                else if(frame.MoveLeft())
                {
                    Solve.Solving(frame, 3);

                }
            }
            /*switch (direction)
            {
                case 0:
                    {
                        frame.MoveUp();
                    }break;
                case 1:
                    {
                        frame.MoveDown();
                    } break;
                case 2:
                    {
                        frame.MoveRight();
                    } break;
                case 3:
                    {
                        frame.MoveLeft();
                    } break;
            }

            else
            {
                Solve.Solving(frame, 0);
                Solve.Solving(frame, 1);
                Solve.Solving(frame, 2);
                Solve.Solving(frame, 3);
            }*/
            return false;
        }

        public static Frame GenerateCorrectFrame(Frame frame)
        {
            Frame f = new Frame(frame.Board.GetLength(0), frame.Board.GetLength(1));
            for (int i = 0; i < f.Board.GetLength(0); i++)
            {
                for (int j = 0; j < f.Board.GetLength(1); j++)
                {
                    if(i == f.Board.GetLength(0)-1 && j == f.Board.GetLength(1)-1)
                    {
                        f.Board[i, j] = new Puzzle(0, i, j);

                    }
                    else
                    {
                        f.Board[i, j] = new Puzzle(4 * i + j + 1, i, j);

                    }
                }
            }
            return f;
        }

    }
}
