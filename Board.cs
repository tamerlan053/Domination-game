using System.Windows.Controls;

namespace Domination
{
    public class Board
    {
        private Block[,] _blocks;

        public Board(int rows, int columns, int margin, int blockWidth) {
            _blocks = new Block[rows, columns];
        }
    }
}

