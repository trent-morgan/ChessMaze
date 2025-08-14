using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessMaze
{
    internal class ChessMazeController(Game game)
    {
        private readonly Game _game = game; //Using Primary Constructor

        public void Go()
        {
            //Create the first level
            int lvl1_id = 1;
            string lvl1_name = "Level 1";
            IBoard lvl1_board = new Board(6, 6, new MoveValidator();
            IPosition lvl1_start = new Position(1, 1);
            IPosition lvl1_end = new Position(6, 6);
            IPlayer lvl1_player = new Player(lvl1_start);
            Level _level1 = new(lvl1_name, lvl1_id, lvl1_board, lvl1_start, lvl1_end, lvl1_player);

            //Load and start the first level
            _game.LoadLevel(_level1);
            _game.StartGame();
        }
    }
}
