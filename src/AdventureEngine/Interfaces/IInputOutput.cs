using JetBrains.Annotations;

namespace AdventureEngine.Interfaces
{
    public interface IInputOutput
    {
        string ReadLine();

        [StringFormatMethod("format")]
        void WriteLine(string format, params object[] args);
    }
}