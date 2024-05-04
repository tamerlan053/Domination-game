using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Domination
{
    public class Block
    {
        private Rectangle _rectangle;
        private Player _owner;
    }

    public Block(int rowNumber, int colomNumber, int margin, int width)
    {
        _rectangle = new Rectangle()
        {

        };
        _owner = Player.None;
    }
}
