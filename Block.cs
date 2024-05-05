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

        public Block(int rowNumber, int colomNumber, int margin, int width)
        {
            _rectangle = new Rectangle()
            {
                Width = width,
                Height = width,
                Stroke = new SolidColorBrush(Colors.Black),
                Margin = new Thickness((colomNumber * width) + margin, (rowNumber * width) + margin, 0, 0)
            };
            _owner = Player.None;
        }

        public Player Owner
        {
            get { return _owner; }
            set { 
                _owner = value;
                if (value == Player.Red)
                {
                    _rectangle.Fill = new SolidColorBrush(Colors.Red);
                } else
                {
                    _rectangle.Fill = new SolidColorBrush(Colors.Red);
                }
            }
        }

        public void DisplayBlockOnCanvas(Canvas canvas)
        {
            canvas.Children.Add(_rectangle);
        }
    }
}
