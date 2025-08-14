using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessMaze
{
    internal class MoveValidator : IMoveValidator
    {
        public bool IsValidMove(PieceType pieceType, IPosition from, IPosition to, IBoard board)
        {
            //Check is positio exists on board
            if (!board.IsValidPosition(to))
                return false;

            //Checks if piece is actually moving
            if (from == to)
                return false;

            int rowDiff = to.Row - from.Row;
            int colDiff = to.Column - from.Column;

            bool isStraight = from.Row == to.Row || from.Column == to.Column;
            bool isDiagonal = Math.Abs(rowDiff) == Math.Abs(colDiff);

            int rowStep = Math.Sign(rowDiff);
            int colStep = Math.Sign(colDiff);

            //Checks if path is clear
            bool PathIsClear()
            {
                int currentRow = from.Row + rowStep;
                int currentCol = from.Column + colStep;

                while (currentRow != to.Row || currentCol != to.Column)
                {
                    var pos = new Position(currentRow, currentCol);
                    if (board.GetPieceAt(pos).Type != PieceType.Empty)
                        return false;

                    currentRow += rowStep;
                    currentCol += colStep;
                }
                return true;
            }

            switch (pieceType)
            {
                case PieceType.King:
                    //Moves one space in any direction
                    return Math.Abs(rowDiff) <= 1 && Math.Abs(colDiff) <= 1;

                case PieceType.Queen:
                    //Moves any amount of spaces in any direction
                    if (!isStraight && !isDiagonal)
                        return false;
                    return PathIsClear();

                case PieceType.Rook:
                    //Moves any amount of spaces vertically or horizontally
                    if (!isStraight)
                        return false;
                    return PathIsClear();

                case PieceType.Bishop:
                    //Moves any amount of spaces diagonally
                    if (!isDiagonal)
                        return false;
                    return PathIsClear();

                case PieceType.Knight:
                    //Moves 1 space in a straight direction and 2 spaces in a perpindicular direction 
                    //or 2 spaces in a straight direction and 1 space in a perpindicular direction 
                    return (Math.Abs(rowDiff) == 2 && Math.Abs(colDiff) == 1) ||
                           (Math.Abs(rowDiff) == 1 && Math.Abs(colDiff) == 2);

                case PieceType.Pawn:
                    // Pawn logic here...
                    return true;

                default:
                    return false;
            }
        }

    }
}
