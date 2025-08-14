using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessMaze
{
    internal class Level(string name, int id, IBoard board, IPosition start, IPosition end, IPlayer player) : ILevel
    {
        public string Name { get; set; } = name;
        public int Id { get; set; } = id;
        public IBoard Board { get; private set; } = board;
        public IPosition StartPosition { get; set; } = start;
        public IPosition EndPosition { get; set; } = end;
        public IPlayer Player { get; private set; } = player;
        public bool IsCompleted { get; private set; }

        public bool CheckCompletion(IPosition playerPosition)
        {
            //Updates IsCompleted if players position is the end position and returns true, false otherwise
            if (playerPosition.Equals(EndPosition))
            {
                IsCompleted = true;
                return true;
            }

            IsCompleted = false;
            return false;
        }

        public void Reset()
        {
            //Resets completion, players position and the board state
            IsCompleted = false;
            Player.ResetPosition(StartPosition);
            Board.ResetBoard(); 
        }
    }
}
