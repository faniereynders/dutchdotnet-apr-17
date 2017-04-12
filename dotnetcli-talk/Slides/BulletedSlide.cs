using ConsolePoint;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;

namespace dotnetcli.Slides
{
    public abstract class BulletedSlide : ISlide
    {
        private Colorful.FigletFont titleFont = Colorful.FigletFont.Load("./fonts/standard.flf");
        private Colorful.FigletFont bulletFont = Colorful.FigletFont.Load("./fonts/mini.flf");

        public abstract int Index { get; }
        protected abstract string Title { get; }

        protected abstract string[] Bullets { get; }

        protected virtual string[] Footers => new string[] { };

        public async Task Execute()
        {
            Console.WriteLine("\n\n");
            Colorful.Console.WriteAscii($"  {Title}", titleFont, Color.Cyan);
            Console.WriteLine("\n");
            foreach (var bullet in Bullets)
            {
                Colorful.Console.WriteAscii($"    -> {bullet}", bulletFont);
            }
            Console.WriteLine("\n");
            foreach (var footer in Footers)
            {
                Console.WriteLine($"        {footer}");
            }
            
        }
    }
}
