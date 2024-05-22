using System.Windows;

namespace Domination
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Player _currentPlayer;
        private int _sizeBlock;
        private int _margin;
        private Board _board;

        public MainWindow()
        {
            InitializeComponent();
            _sizeBlock = 40; 
            _board = new Board(8, 8, _margin, _sizeBlock);
            _board.DisplayBoardOnCanvas(paperCanvas);
            _currentPlayer = Player.Red;
        }

        private void paperCanvas_MouseUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Point mousePosition = e.GetPosition(paperCanvas);
            double x = mousePosition.X;
            double y = mousePosition.Y;

            int rowIndex = (int)(y / (_sizeBlock + _margin));
            int colIndex = (int)(x / (_sizeBlock + _margin));

            try
            {
                _board.ClaimBlocks(rowIndex, colIndex, _currentPlayer);

                bool hasMoveLeft = _board.HasMoveLeftFor(_currentPlayer);

                if (!hasMoveLeft)
                {
                    MessageBox.Show($"Player {_currentPlayer} wins!");
                } else
                {
                    if (_currentPlayer == Player.Red)
                    {
                        _currentPlayer = Player.Blue;
                    } else
                    {
                        _currentPlayer = Player.Red;
                    }
                }
            } catch (DominationException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
