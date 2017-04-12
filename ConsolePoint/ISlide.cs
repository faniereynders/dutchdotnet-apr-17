using System.Threading.Tasks;

namespace ConsolePoint
{
    public interface ISlide
    {
        int Index { get; }
        Task Execute();
    }
}
