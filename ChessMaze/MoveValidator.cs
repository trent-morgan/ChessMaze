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
            if (board.IsValidPosition(to) == false)
                return false;

            //switch (pieceType)
            //{
            //    case PieceType.King:
            //        return ;

            //    case PieceType.Queen:
            //        return ;

            //    case PieceType.Rook:
            //        return ;

            //    case PieceType.Bishop:
            //        return ;

            //    case PieceType.Knight:
            //        return ;

            //    case PieceType.Pawn:
            //        
            //        return ;

            //    default:
            //        return false;
            //}
        }
    }
}
