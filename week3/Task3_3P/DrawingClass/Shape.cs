using SplashKitSDK;

namespace DrawingClass
{
    public class Shape
    {
        private Color _color;
        private float _x;
        private float _y;
        private int _width;
        private int _height;

        public Shape(int param)
        {
            _color = Color.Chocolate;
            _x = 0.0f;
            _y = 0.0f;
            _width = param;
            _height = param;
        }

        public Color Color
        {
            get
            {
                return _color;
            }
            set
            {
                _color = value;
            }
        }

        public float X
        {
            get
            {
                return _x;
            }
            set
            {
                _x = value;
            }
        }

        public float Y
        {
            get
            {
                return _y;
            }
            set
            {
                _y = value;
            }
        }

        public int Width
        {
            get
            {
                return _width;
            }
            set
            {
                _width = value;
            }
        }

        public int Height
        {
            get
            {
                return _height;
            }
            set
            {
                _height = value;
            }
        }

        public void Draw()
        {
            if(Selected)
            {
                DrawOutline();
            }
            SplashKit.FillRectangle(_color, _x, _y, _width, _height);
        }

        public Boolean IsAt(Point2D pt)
        {
            if (pt.X > _x && pt.X < _x + _width && pt.Y > _y && pt.Y < _y + _height)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool _selected;
        public bool Selected
        {
            get
            {
                return _selected;
            }
            set
            {
                _selected = value;
            }
        }

        public void DrawOutline()
        {
            SplashKit.FillRectangle(Color.Black, _x-(5+3), _y-(5+3), _width+2*(5+3), _height+2*(5+3));
        }
    }
}
