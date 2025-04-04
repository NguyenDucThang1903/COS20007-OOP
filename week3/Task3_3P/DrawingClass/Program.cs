using System;
using SplashKitSDK;

namespace DrawingClass
{
    public class Program
    {
        public static void Main()
        {


            Window window = new Window("Shape Drawer", 800, 600);

            Drawing myDrawing = new Drawing();

            do
            {
                SplashKit.ProcessEvents();
                SplashKit.ClearScreen();

                Shape newShape = new Shape(103);
                if(SplashKit.MouseClicked(MouseButton.LeftButton))
                {
                    newShape.X = SplashKit.MouseX();
                    newShape.Y = SplashKit.MouseY();
                    myDrawing.AddShape(newShape);

                }

                if(SplashKit.KeyTyped(KeyCode.SpaceKey))
                {
                    myDrawing.BackGround = SplashKit.RandomColor();
                }

                if (SplashKit.MouseClicked(MouseButton.RightButton))
                {
                    myDrawing.SelectShapeAt(SplashKit.MousePosition());
                }

                if(SplashKit.KeyTyped(KeyCode.DeleteKey) || SplashKit.KeyTyped(KeyCode.BackspaceKey))
                {
                    foreach (Shape s in myDrawing.SelectedShapes)
                    {
                        myDrawing.RemoveShape(s);
                    }
                }

                myDrawing.Draw();
                SplashKit.RefreshScreen();
            } while (!window.CloseRequested);
        }
    
    }
}
