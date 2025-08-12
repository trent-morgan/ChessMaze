using System;

namespace ChessMaze
{
    internal class Game : IGame
    {
        //Added new attributes: moveCount and _moveValidator

        //moveCount attribute counts the amount of moves done within the game, resets when game is reset
        private int moveCount = 0;
        private readonly IMoveValidator _moveValidator;

        public ILevel CurrentLevel { get; private set; }
        public GameStatus Status { get; private set; } = GameStatus.Ongoing;

        public Game(IMoveValidator moveValidator)
        {
            _moveValidator = moveValidator;
        }

        public void LoadLevel(ILevel level)
        {
            CurrentLevel = level;
        }

        public void StartGame()
        {
            moveCount = 0;
            Status = GameStatus.Ongoing;
            CurrentLevel.Reset();
        }

        public bool Move(IPosition newPosition)
        {
            if (Status != GameStatus.Ongoing || CurrentLevel == null)
                return false;

            var player = CurrentLevel.Player;
            var board = CurrentLevel.Board;
            var from = player.CurrentPosition;

            if (!board.IsValidPosition(newPosition) || !board.IsMoveLegal(from, newPosition, _moveValidator))
            {
                return false;
            }

            player.SetPosition(newPosition);
            moveCount++;

            if (CurrentLevel.CheckCompletion(newPosition))
            {
                Status = GameStatus.Won;
            }

            return true;
        }

        public int GetMoveCount()
        {
            return moveCount;
        }

        public void ResetLevel()
        {
            moveCount = 0;
            Status = GameStatus.Ongoing;
            CurrentLevel.Reset();
        }
    }
}
