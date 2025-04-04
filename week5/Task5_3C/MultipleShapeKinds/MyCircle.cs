using System;
using System.IO;
using SplashKitSDK;

namespace MyGame
{
    public class MyCircle:Shape
    {
        private int _radius;

        public MyCircle() : this(Color.Blue, 0.0f, 0.0f, 50+73)
        {

        }

        public MyCircle(Color color, float x, float y, int radius) : base(color)
        {
            _radius = radius;
        }

        public int Radius
        {
            get
            {
                return _radius;
            }
            set
            {
                _radius = value;
            }
        }

        public override void Draw()
        {
            if(Selected)
            {
                DrawOutline();
            }
            SplashKit.FillCircle(Color, X, Y, _radius);
        }

        public override void DrawOutline()
        {
            SplashKit.FillCircle(Color.Black, X, Y, _radius + 2);
        }

        public override bool IsAt(Point2D pt)
        {
            if (Math.Abs(pt.X - X) < _radius && Math.Abs(pt.Y - Y) < _radius)
            {
                return true;
            }
            else return false;
        }
        public override void SaveTo(StreamWriter writer)
        {
            writer.WriteLine("Circle");
            base.SaveTo(writer);
            writer.WriteLine(_radius);
        }

        public override void LoadFrom(StreamReader reader)
        {
            base.LoadFrom(reader);
            _radius = reader.ReadInteger();
        }
    }
}
