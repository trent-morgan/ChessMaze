using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessMaze
{
    internal class Level : ILevel
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public IBoard Board { get; private set; }
        public IPosition StartPosition { get; set; }
        public IPosition EndPosition { get; set; }
        public IPlayer Player { get; private set; }
        public bool IsCompleted { get; private set; }

        public Level(string name, int id, IBoard board, IPosition start, IPosition end, IPlayer player )
        {
            Name = name;
            Id = id;
            Board = board;
            StartPosition = start;
            EndPosition = end;
            Player = player;
        }

        public bool CheckCompletion(IPosition playerPosition)
        {
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
            IsCompleted = false;
            Player.ResetPosition(StartPosition);
            Board.ResetBoard(); 
        }
    }
}
