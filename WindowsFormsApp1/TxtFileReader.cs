using System.IO;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Services // KENDİ PROJE ADINI YAZMAYI UNUTMA
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
} // <- Dosya tam olarak burada, bu parantezle bitmeli. Altında başka hiçbir şey (özellikle fazladan bir } işareti) olmamalı.