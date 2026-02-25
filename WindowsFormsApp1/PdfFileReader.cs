using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UglyToad.PdfPig;
using WindowsFormsApp1.Services; // PDF kütüphanesi

namespace WindowsFormsApp1
{
    public class PdfFileReader : IFileReader
    {
        public async Task<string> ReadAsync (string filePath)
        {
            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException("seçilen pdf bulunamadı");
            }
            return await Task.Run(() =>
            {
                StringBuilder sb = new StringBuilder();

                using (PdfDocument document = PdfDocument.Open(filePath))
                {
                    foreach (var page in document.GetPages())
                    {
                        sb.AppendLine(page.Text);
                    }
                }
                return sb.ToString();
            });
        }
    }
}