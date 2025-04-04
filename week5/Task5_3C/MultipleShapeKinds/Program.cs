using System;
using SplashKitSDK;
using System.IO;
using System.Xml.Linq;

namespace MyGame
{
    public class Program
    {
        private enum ShapeKind
        {
            Rectangle,
            Circle,
            Line
        }
        public static void Main()
        {
            ShapeKind kindToAdd = ShapeKind.Circle;

            Window window = new Window("Shape Drawer", 800, 600);

            Drawing myDrawing = new Drawing();

            int count=0;
            do
            {
                SplashKit.ProcessEvents();
                SplashKit.ClearScreen();

                if(SplashKit.KeyTyped(KeyCode.RKey))
                {
                    kindToAdd = ShapeKind.Rectangle;
                    Console.WriteLine("rectangle");
                    count = 0;
                }

                if(SplashKit.KeyTyped(KeyCode.CKey))
                {
                    kindToAdd = ShapeKind.Circle;
                    Console.WriteLine("circle");
                    count = 0;
                }

                if (SplashKit.KeyTyped(KeyCode.LKey))
                {
                    kindToAdd = ShapeKind.Line;
                    Console.WriteLine("line");
                    count = 0;
                }

                if (SplashKit.MouseClicked(MouseButton.LeftButton) && count<3)
                {
                    Shape newShape;

                    switch(kindToAdd)
                    {
                        case ShapeKind.Circle:
                            newShape = new MyCircle();
                            break;

                        case ShapeKind.Line:
                            newShape = new MyLine();
                            count++;
                            break;

                        default:
                            newShape = new MyRectangle();
                            break;

                    }
                    

                    newShape.X = SplashKit.MouseX();
                    newShape.Y = SplashKit.MouseY();
                    myDrawing.AddShape(newShape);
                }

                if(SplashKit.KeyTyped(KeyCode.SpaceKey))
                {
                    myDrawing.BackGround = SplashKit.RandomColor();
                }

                if(SplashKit.MouseClicked(MouseButton.RightButton))
                {
                    myDrawing.SelectShapeAt(SplashKit.MousePosition());
                }

                string file_path = "E:/COS20007/week5/Task5_3C/MultipleShapeKinds/TestDrawing.txt";

                if (SplashKit.KeyTyped(KeyCode.DeleteKey) || SplashKit.KeyTyped(KeyCode.BackspaceKey))
                {
                    foreach(Shape s in myDrawing.SelectedShapes)
                    {
                        myDrawing.RemoveShape(s);
                    }
                }

                if(SplashKit.KeyTyped(KeyCode.SKey))
                {
                    
                    myDrawing.Save(file_path);

                    Console.WriteLine($"Drawing saved to {file_path}");
                }

                if(SplashKit.KeyTyped(KeyCode.OKey))
                {
                    try
                    {
                        myDrawing.Load(file_path);
                    }
                    catch(Exception e)
                    {
                        Console.Error.WriteLine("Error loading file: {0}", e.Message);
                    }
                }

                myDrawing.Draw();
                SplashKit.RefreshScreen();
            } while (!window.CloseRequested);
        }

    }
}
