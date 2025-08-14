using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessMaze
{
    internal class Position : IPosition
    {
        public int Row { get; set; }
        public int Column { get; set; }
        public Position(int row, int column)
        {
            this.Row = row;
            this.Column = column;
        }

        public bool Equals(IPosition other)
        {
            if (other.Row == this.Row && other.Column == this.Column)
            {
                return true;
            }
            return false;
        }

        public bool IsValid(int maxRows, int maxColumns)
        {
            if (this.Row <= maxRows && this.Column <= maxColumns)
            {
                return true;
            }
            return false;
        }
    }
}
