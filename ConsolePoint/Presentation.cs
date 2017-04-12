using Microsoft.Extensions.DependencyInjection;
using Scrutor;
using System;
using System.Linq;
using System.Reflection;

namespace ConsolePoint
{
    public abstract class Presentation
    {
        private readonly ISlide[] slides;
        
        public Presentation()
        {
            var services = new ServiceCollection();

            var provider = services.Scan(scan => scan
                     .FromAssemblies(Assembly.GetEntryAssembly())
                     .AddClasses(classes => classes.AssignableTo<ISlide>())
                     .AsImplementedInterfaces()
                     .WithTransientLifetime())
                     .BuildServiceProvider();

            slides = provider.GetServices<ISlide>().OrderBy(s=>s.Index).ToArray();
        }

        public ISlide[] Slides => slides;

        public void Start()
        {
            var id = 0;
            Setup();
            while (true)
            {
                Reset();
                slides[id].Execute().Wait();

                var key = Console.ReadKey();
                if (key.Key == ConsoleKey.RightArrow)
                {
                    id++;
                }
                else if (key.Key == ConsoleKey.LeftArrow && id > 0)
                {
                    id--;
                }

                if (id >= slides.Length)
                {
                    break;
                }
            }

            Reset();

            End();
        }

        protected virtual void Reset()
        {
            Console.Clear();
            Console.ResetColor();
        }

        protected abstract void Setup();
        protected abstract void End();
    }
}
