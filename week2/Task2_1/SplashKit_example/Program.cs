using System;
using SplashKitSDK;

namespace SplashKit_example
{
    public class Program
    {
        public static void Main()
        {
            Window window = new Window("Nguyen Duc Thang 104776473", 800, 600);

            do
            {
                SplashKit.ProcessEvents();
                SplashKit.ClearScreen();
                SplashKit.RefreshScreen();
            } while (!window.CloseRequested);

        }
    }
}
