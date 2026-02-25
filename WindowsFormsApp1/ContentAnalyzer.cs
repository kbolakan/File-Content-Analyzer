using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.Services
{
    public class ContentAnalyzer
    {
        public AnalysisResult Analyze(string text)
        {
            var result = new AnalysisResult
            {
                WordFrequencies = new Dictionary<string, int>()
            };

            if (string.IsNullOrWhiteSpace(text))
                return result;

            // Noktalama işaretlerini kusursuz say
            result.TotalPunctuations = text.Count(char.IsPunctuation);

            // \p{L} -> Tüm dillerdeki harfleri temsil eder.
            // \p{Nd} -> Rakamları temsil eder.
            MatchCollection matches = Regex.Matches(text.ToLower(), @"[\p{L}\p{Nd}]+");

            foreach (Match match in matches)
            {
                string word = match.Value;

                // Kelimeyi sözlüğe ekle veya sayısını artır
                if (result.WordFrequencies.ContainsKey(word))
                {
                    result.WordFrequencies[word]++;
                }
                else
                {
                    result.WordFrequencies.Add(word, 1);
                }
            }

            // kelime sayısını hesapla
            result.TotalDistinctWords = result.WordFrequencies.Count;

            return result;
        }
    }
}