using ConsolePoint;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;

namespace dotnetcli.Slides
{
    public class _1__Intro : ISlide
    {
        public int Index => 1;

        public async Task Execute()
        {
            Console.WriteLine("\n\n");
            Colorful.Console.WriteAscii("    .NET Core CLI", Colorful.FigletFont.Load("./fonts/basic.flf"), Color.LawnGreen);
            Colorful.Console.WriteAscii("    demystified", Colorful.FigletFont.Load("./fonts/cosmic.flf"), Color.LightCyan);
            Console.WriteLine("\n\n");
            Colorful.Console.WriteAscii("    Fanie Reynders", Colorful.FigletFont.Load("./fonts/mini.flf"), Color.Yellow);
            Console.WriteLine("\n\n");
            Console.WriteLine("\t\t\t- Software Engineer");
            Console.WriteLine("\t\t\t- Microsoft MVP");
            Console.WriteLine("\t\t\t- Coolest dad");
            Console.WriteLine("\t\t\t- @FanieReynders");
            Console.WriteLine("\t\t\t- reynders.co");
        }
    }
}
