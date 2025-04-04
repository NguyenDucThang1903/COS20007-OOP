using SplashKitSDK;
using System;
using System.IO;

namespace MyGame
{
    public class MyRectangle:Shape
    {
        private int _width;
        private int _height;
        public MyRectangle() : this(Color.Green, 0.0f, 0.0f, 173, 173)
        {

        }

        public MyRectangle(Color color, float x, float y, int width, int height) : base(color)
        {
            X = x;
            Y = y;
            _width = width;
            _height = height;
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

        public override void Draw()
        {
            if (Selected)
            {
                DrawOutline();
            }
            SplashKit.FillRectangle(Color, X, Y, _width, _height);
        }

        public override void DrawOutline()
        {
            SplashKit.FillRectangle(Color.Black , X - (5 + 3), Y - (5 + 3), _width + 2 * (5 + 3), _height + 2 * (5 + 3));
        }

        public override bool IsAt(Point2D pt)
        {
            if (pt.X > X && pt.X < X + _width && pt.Y > Y && pt.Y < Y + _height)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override void SaveTo(StreamWriter writer)
        {
            writer.WriteLine("Rectangle");
            base.SaveTo(writer);
            writer.WriteLine(_width);
            writer.WriteLine(_height);
        }

        public override void LoadFrom(StreamReader reader)
        {
            base.LoadFrom(reader);
            _width = reader.ReadInteger();
            _height = reader.ReadInteger();
        }
    }
}
