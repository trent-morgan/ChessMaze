using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessMaze
{
    internal class Board(int rows, int columns) : IBoard
    {
        //Added dictionary of position to the piece associated with it
        //e.g. positionPiece[Position(0,0)] = Piece(PieceType.King, true)
        private Dictionary<IPosition, IPiece> positionPiece = new Dictionary<IPosition, IPiece>();

        //Primary constructor
        public int Rows { get; set; } = rows;
        public int Columns { get; set; } = columns;

        public void SetPiece(IPiece piece, IPosition position)
        {
            if (IsValidPosition(position))
            {
                positionPiece[position] = piece;
            }
        }

        public IPiece GetPieceAt(IPosition position)
        {
            if (positionPiece.TryGetValue(position, out IPiece piece))
            {
                return piece;
            }
            return new Piece(PieceType.Empty, false);
        }

        public bool TryMovePiece(IPosition from, IPosition to)
        {
            if (!IsValidPosition(from) || !IsValidPosition(to))
            {
                return false;
            }
            switch ()
        }

        public bool IsValidPosition(IPosition position)
        {
            if ((0 <= position.Row && position.Row <= this.Rows) && ((0 <= position.Column && position.Column <= this.Columns)))
            {
                return true;
            }
            return false;
        }

        public bool IsMoveLegal(IPosition from, IPosition to, IMoveValidator validator)
        {
            
        }

        public void ResetBoard()
        {
            positionPiece = [];
        }
    }
}
