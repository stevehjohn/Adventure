using JetBrains.Annotations;

namespace AdventureEngine.Infrastructure
{
    public interface IInputOutput
    {
        string ReadLine();

        [StringFormatMethod("format")]
        void WriteLine(string format, params object[] args);
    }
}