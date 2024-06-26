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

        public void ClaimBlocks(int rowIndex,  int columnIndex, Player player) {
            if (_blocks[rowIndex, columnIndex].Owner != Player.None)
            {
                throw new DominationException("Error, it is busy!");
            };

            if (player == Player.Red)
            {
                if (rowIndex + 1 >= _blocks.GetLength(0))
                {
                    throw new DominationException("Underlying block does not exist!");
                }

                if (_blocks[rowIndex + 1, columnIndex].Owner != Player.None) {
 
                    throw new DominationException("Error, underlying block is busy!");
                }
                
                _blocks[rowIndex, columnIndex].Owner = Player.Red;
                _blocks[rowIndex + 1, columnIndex].Owner = Player.Red;
            } else if (player == Player.Blue) {
                
            }
        }
    }
}

