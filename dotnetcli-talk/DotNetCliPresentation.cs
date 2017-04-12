using ConsolePoint;
using System;

namespace dotnetcli
{
    public class DotNetCliPresentation : Presentation
    {
        protected override void Setup()
        {
            Console.WindowLeft = Console.WindowTop = 0;
            Console.WindowHeight = Console.BufferHeight = Console.LargestWindowHeight;
            Console.WindowWidth = Console.BufferWidth = Console.LargestWindowWidth;

            Console.WriteLine("Full screen and go!");
            Console.ReadKey();
        }
        protected override void End()
        {
            Console.WriteLine("End of show");

            Console.ReadKey();
        }
    }
}
