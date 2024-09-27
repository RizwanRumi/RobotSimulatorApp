using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotSimulatorTestApp
{
    public enum Direction { N, E, S, W }

    public class DataBlock
    {
        public int Rows { get; }
        public int Columns { get; }
        public int CurrentRow { get; set; }
        public int CurrentColumn { get; set; }
        public Direction CurrentDirection { get; set; }
        public string Commands { get; }

        public DataBlock(int rows, int columns, int currentRow, int currentColumn, Direction direction, string commands)
        {
            this.Rows = rows;
            this.Columns = columns;
            this.CurrentRow = currentRow;
            this.CurrentColumn = currentColumn;
            this.CurrentDirection = direction;  
            this.Commands = commands;
        }
    }
}
