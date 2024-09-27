using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotSimulatorTestApp
{
    // Design pattern: Factory method
    public interface IMove
    {

        public int Move(int position, int boundary);
    }
    public class MoveUp : IMove
    {
        public int Move(int position, int boundary)
        {
            int row = position;
            if (row > 0) row--;
            return row;
        }
    }

    public class MoveDown : IMove
    {
        public int Move(int position, int boundary)
        {
            int row = position;
            int maxRows = boundary;

            if (row < maxRows - 1) row++;
            return row;
        }
    }

    public class MoveRight : IMove
    {
        public int Move(int position, int boundary)
        {
            int col = position;
            int maxCols = boundary;

            if (col < maxCols - 1) col++;
            return col;
        }
    }

    public class MoveLeft : IMove
    {
        public int Move(int position, int boundary)
        {
            int col = position;
            if (col > 0) col--;
            return col;
        }
    }
}
