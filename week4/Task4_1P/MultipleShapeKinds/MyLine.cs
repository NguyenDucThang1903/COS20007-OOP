using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SplashKitSDK;

namespace MultipleShapeKinds
{
    public class MyLine:Shape
    {
        private float _endX;
        private float _endY;

        public MyLine() : this(Color.Red, 0.0f, 0.0f, 10, 10)
        {

        }

        public MyLine(Color color, float startX, float startY, float endX, float endY) : base(color)
        {
            X = startX;
            Y = startY;
        }

        public float EndX
        {
            get
            {
                return _endX;
            }
            set
            {
                _endX = value;
            }
        }

        public float EndY
        {
            get
            {
                return _endY;
            }
            set
            {
                _endY = value;
            }
        }

        public override void Draw()
        {
            if (Selected)
            {
                DrawOutline();
            }
            SplashKit.DrawLine(Color, X, Y, _endX, _endY);
        }

        public override void DrawOutline()
        {
            SplashKit.FillCircle(Color.Black, X, Y, 2);
            SplashKit.FillCircle(Color.Black, _endX, _endY, 2);
        }

        public override bool IsAt(Point2D pt)
        {
            if (SplashKit.PointOnLine(pt, SplashKit.LineFrom(X, Y, _endX, _endY)))
            {
                return true;
            }
            else return false;
        }
    }
}
