using System.Drawing;

namespace Sudoku
{
    internal class Program
    {
        private int[,] grid;

        public Program()
        {
            grid = new int[9, 9];
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("Sudoku!");

            Program program = new Program();

            int[,] grid =
            {
                {0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0}
            };

            for (int i = 0; i < 9; i++)
                for (int j = 0; j < 9; j++)
                    program.EnterToGrid(grid[i, j], new Point(i, j));
            Console.WriteLine("Algne ruudustik");

            program.Display();

            program.Solve(program.NextAvailableCell(), new Point());

            Console.WriteLine("\n\n\nSolved Grid");

            program.Display();

            Console.WriteLine();
        }

        public void Display()
        {
            for (int i = 0; i < 9; i++)
            {
                Console.WriteLine();

                for (int j = 0; j < 9; j++)
                {
                    if (ShowFromGrid(new Point(i, j)) == 0)
                    {
                        Console.Write("0");

                    }
                    else
                    {
                        Console.Write(ShowFromGrid(new Point(i, j)) + " ");
                    }
                    if (j == 2 || j == 5)
                    {
                        Console.Write("| ");
                    }
                }
                if (i == 2 || i == 5)
                {
                    Console.Write("\n------|------|------");

                }
            }
        }
        public Point NextAvailableCell()
        {
            for (int i = 0; i < 9; i++)
                for (int j = 0; j < 9; j++) 
                for (int k = 0; k < 9; k++) 
                    if (grid[i, j] == 0)
                    {
                        return new Point(i, j);
                    }
                

            return new Point();
        }
        public bool IsThisNumberPossibleGrid(int num, Point pos)
        {
            if (IsThisNumberPossibleBlock(num, pos))
            {
                for (int i = 0; i < 9; i++)
                {
                    if (grid[i, pos.Y] == num && pos.X != i)
                    {
                        return false;
                    }

                    if (grid[pos.X, pos.X] == num && pos.Y != i)
                    {
                    return false;
                    }
                }
            return true;
            }
        return false;
        }

        public bool IsThisNumberPossibleBlock(int num, Point pos)
        {
            Point Grid = new Point();

            Grid.X = (pos.X >= 0 && pos.X <= 2) ? 0 : ((pos.X >= 3 && pos.X <= 5) ? 3 : ((pos.X >= 6 && pos.X <= 8)? 6 : -1));
            Grid.Y = (pos.Y >= 0 && pos.Y <= 2) ? 0 : ((pos.Y >= 3 && pos.Y <= 5) ? 3 : ((pos.Y >= 6 && pos.Y <= 8)? 6 : -1));

            if (!Grid.Equals(new Point ()))
            {
                for (int i = Grid.X; i < Grid.X + 3; i++)
                {
                    for (int j = Grid.Y; j < Grid.Y + 3; j++)
                    {
                        if (grid[i, j] == num && !pos.Equals(new Point(i, j)))
                            return false;
     
                    }
                    return true;
                }
                return false;

            }
        }
        public void EnterToGrid(int num, Point pos)
        {
            grid[pos.X, pos.Y] = num;
        }
        public int ShowFromGrid(Point pos)
        {
            return grid[pos.X, pos.Y];
        }
         public void Solve(Point pos, Point prevPos)
        {
            if (pos.X < 9 && pos.Y < 9)
            {
                Point posPre = new Point();

                if (grid[pos.X, pos.Y] == 0)
                {
                    for (int i = 1; i <= 9 ; i++)
                    {
                        if (IsThisNumberPossibleGrid(i, pos))
                        {
                            grid[pos.X, pos.Y] = i;

                            posPre.X = pos.X;

                            posPre.Y = pos.Y;

                            Point posNext = NextAvailableCell();

                            if (!posNext.Equals(new Point()))
                                Solve(posNext, posPre);

                        }
                    }
                    if (grid[pos.X, pos.Y] == 0)
                    {
                        if (!prevPos.Equals(new Point()))
                            grid[prevPos.X, prevPos.Y] = 0;
                        

                        return;
                    }
                }
            }
            else
            {
                Point posNext = NextAvailableCell();

                if (!posNext.Equals(new Point()))
                
                    Solve(posNext, pos);
                
            }
        }

    }

    public class Point
    {
        public int X;
        public int Y;

        public Point()
        {
            this.X = -1;
            this.Y = -1;
        }

        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public bool Equals(Point p)
        {
            return (this.X == p.X && this.Y== p.Y) ? true : false;
        }

    }
}