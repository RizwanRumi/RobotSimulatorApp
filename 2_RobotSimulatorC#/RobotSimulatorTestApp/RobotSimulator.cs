using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace RobotSimulatorTestApp
{
    public class RobotSimulator
    {
        private IMove? _selectedMove;
        private IRotation? _rotation;

        public RobotSimulator() 
        {
            _selectedMove = null;
            _rotation = null;
        }

        // implemented dependency injection in both Move and SelectedRotation method

        public void Move(DataBlock block)
        {
            if (block.CurrentDirection == Direction.N)
            {               
                _selectedMove = new MoveUp();

                block.CurrentRow = _selectedMove.Move(block.CurrentRow, 0);
            }
            else if (block.CurrentDirection == Direction.E)
            {
                _selectedMove = new MoveRight();
                block.CurrentColumn = _selectedMove.Move(block.CurrentColumn, block.Columns);
            }
            else if (block.CurrentDirection == Direction.S)
            {
                _selectedMove = new MoveDown();
                block.CurrentRow = _selectedMove.Move(block.CurrentRow, block.Rows);
            }
            else if (block.CurrentDirection == Direction.W)
            {
                _selectedMove = new MoveLeft();
                block.CurrentColumn = _selectedMove.Move(block.CurrentColumn, 0);
            }
        }
                
        public Direction SelectedRotation(IRotation rotation, Direction currentDirection)
        {
            _rotation = rotation;
            return _rotation.Rotate(currentDirection);
        }
    }
}

