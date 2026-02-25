using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Services;

namespace WindowsFormsApp1
{
    public class DocxFileReader : IFileReader
    {
        public async Task<string> ReadAsync(string filePath)
        {
            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException("seçilen dosya bulunamadı");
            }
            return await Task.Run(() =>
            {
                StringBuilder sb = new StringBuilder();
                using (WordprocessingDocument worDoc = WordprocessingDocument.Open(filePath, false))
                {
                    Body body = worDoc.MainDocumentPart.Document.Body;

                    foreach (var paragraph in body.Elements<Paragraph>())
                {
                sb.AppendLine(paragraph.InnerText);
                }
                }
                return sb.ToString();
            });
        }
    }
}
