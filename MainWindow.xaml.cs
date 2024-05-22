using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

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
        }
    }
}
