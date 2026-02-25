using System.Threading.Tasks;

namespace WindowsFormsApp1.Services
{
    public interface IFileReader
    {
        Task<string> ReadAsync(string filePath);
    }
}