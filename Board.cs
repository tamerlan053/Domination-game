using System.Windows.Controls;

namespace Domination
{
    public class Board
    {
        private Block[,] _blocks;

        public Board(int rows, int columns, int margin, int blockWidth) {
            _blocks = new Block[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++) {
                    _blocks[i, j] = new Block(i, j, margin, blockWidth);
                }
            }
        }

        public void DisplayBoardOnCanvas(Canvas canvas)
        {
            foreach (Block block in _blocks)
            {
                block.DisplayBlockOnCanvas(canvas);
            }
        }
    }
}

