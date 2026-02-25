using System.IO;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Services
{
    public class TxtFileReader : IFileReader
    {
        public async Task<string> ReadAsync(string filePath)
        {
            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException("The specified file was not found.");
            }

            using (StreamReader reader = new StreamReader(filePath))
            {
                return await reader.ReadToEndAsync();
            }
        }
    }
}