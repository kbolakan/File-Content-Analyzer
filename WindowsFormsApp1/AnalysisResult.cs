using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WindowsFormsApp1.Models
{
    public class AnalysisResult
    {
        public int  TotalDistinctWords {  get; set; }
        public int TotalPunctuations { get; set; }
        public Dictionary<string, int> WordFrequencies { get; set; } = new Dictionary<string, int>();
    }
}