using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace RobotSimulatorTestApp
{
    internal class RobotSimulator
    {
        internal void Move(ref int row, ref int col, Direction direction, int maxRows, int maxCols)
        {
            switch (direction)
            {
                case Direction.N:
                    if (row > 0) row--;
                    break;
                case Direction.E:
                    if (col < maxCols - 1) col++;
                    break;
                case Direction.S:
                    if (row < maxRows - 1) row++;
                    break;
                case Direction.W:
                    if (col > 0) col--;
                    break;
            }
        }

        

        internal Direction RotateRight(Direction direction)
        {
            return (Direction)(((int)direction + 1) % 4);
        }

        internal Direction RotateLeft(Direction direction)
        {
            return (Direction)(((int)direction + 3) % 4);
        }
    }
}

