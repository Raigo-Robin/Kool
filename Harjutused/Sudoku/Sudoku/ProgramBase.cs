namespace Sudoku
{
    internal class ProgramBase
    {

        public bool IsThisNumberPossibleBlock(int num, Point pos)
        {
            Point Grid = new Point();

            Grid.X = (pos.X >= 0 && pos.X <= 2) ? 0 : ((pos.X >= 3 && pos.X <= 5) ? 3 : ((pos.X >= 6 && pos.X <= 8) ? 6 : -1));
            Grid.Y = (pos.Y >= 0 && pos.Y <= 2) ? 0 : ((pos.Y >= 3 && pos.Y <= 5) ? 3 : ((pos.Y >= 6 && pos.Y <= 8) ? 6 : -1));

            if (!Grid.Equals(new Point()))
            {
                for (int i = Grid.X; i < Grid.X + 3; i++)
                {
                    for (int j = Grid.Y; j < Grid.Y; j++)
                    {
                        if (grid[i, j] == num && !pos.Equals(new Point(i, j)))
                            return false;

                    }
                    return true;
                }
                return false;

            }
        }
    }
}