using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessMaze
{
    internal class Board(int rows, int columns, MoveValidator moveValidator) : IBoard
    {
        //Added dictionary of position to the piece associated with it
        //e.g. positionPiece[Position(0,0)] = Piece(PieceType.King, true)
        private Dictionary<IPosition, IPiece> positionPiece = new Dictionary<IPosition, IPiece>();
        
        public int Rows { get; set; } = rows;
        public int Columns { get; set; } = columns;

        //Move validator for IsMoveLegal
        private readonly IMoveValidator _moveValidator = moveValidator;

        public void SetPiece(IPiece piece, IPosition position)
        {
            if (IsValidPosition(position))
            {
                positionPiece[position] = piece;
            }
        }

        public IPiece GetPieceAt(IPosition position)
        {
            //Returms piece at specified position in positionPiece dictionary
            //Does not return piece if null value
            if (positionPiece.TryGetValue(position, out IPiece? piece) && piece != null)
            {
                return piece;
            }
            //Creates empty piece instance and returns if piece unfounf in positionPiece
            return new Piece(PieceType.Empty, false);
        }

        public bool TryMovePiece(IPosition from, IPosition to)
        {
            //Checks if both from and to positions exist in the board
            if (!IsValidPosition(from) || !IsValidPosition(to))
            {
                return false;
            }
            //Uses move validator to make sure the piece is conforming to its valid move set
            if (!IsMoveLegal(from, to, _moveValidator))
            {
                return false;
            }

            return true;
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
            IPiece piece = GetPieceAt(from);
            //Pieces can only go on spaces with opposite color
            if (positionPiece[from].IsWhite == positionPiece[to].IsWhite)
            {
                return false;
            }
            return validator.IsValidMove(piece.Type, from, to, this);
        }

        public void ResetBoard()
        {
            positionPiece = [];
        }
    }
}
