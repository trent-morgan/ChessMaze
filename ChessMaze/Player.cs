using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessMaze
{
    internal class Player : IPlayer
    {
        public IPosition CurrentPosition { get; private set; }
        public Player(IPosition currentPosition) 
        {
            CurrentPosition = currentPosition;
        }

        public void ResetPosition(IPosition startPosition)
        {
            CurrentPosition = startPosition;
        }

        public void SetPosition(IPosition newPosition)
        {
            CurrentPosition = newPosition;
        }
    }
}
