using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotSimulatorTestApp
{
    public interface IRotation
    {
        Direction Rotate(Direction direction);
    }

    public class RotateRight : IRotation
    {
        public Direction Rotate(Direction direction)
        {
            return (Direction)(((int)direction + 1) % 4);
        }
    }

    public class RotateLeft : IRotation
    {
        public Direction Rotate(Direction direction)
        {
            return (Direction)(((int)direction + 3) % 4);
        }
    }
}
