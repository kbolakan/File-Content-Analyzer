using System;
using System.ComponentModel;
using System.Windows.Forms;
using WindowsFormsApp1.Models;   // Models klasörünü çağırıyoruz
using WindowsFormsApp1.Services; // Services klasörünü çağırıyoruz

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        // Analiz sınıfımızı tanımlıyoruz
        private readonly ContentAnalyzer _analyzer;

        public Form1()
        {
            InitializeComponent();
            _analyzer = new ContentAnalyzer();
            Log("Application initialized.");
            cmbFileType.SelectedIndexChanged += cmbFileType_SelectedIndexChanged;
            btnLoadFile.Click += btnLoadFile_Click;
            // COMBOBOX'A PDF SEÇENEĞİNİ KOD İLE EKLİYORUZ:
            if (!cmbFileType.Items.Contains(".pdf"))
            {
                cmbFileType.Items.Add(".pdf");
            }
        }

        // --- BİZİM DOLDURDUĞUMUZ METODLAR ---

        // Tür seçilince buton aktif olsun
        private void cmbFileType_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnLoadFile.Enabled = cmbFileType.SelectedIndex != -1;
        }

        // Yükle butonuna basılınca çalışacak ana kod
        private async void btnLoadFile_Click(object sender, EventArgs e)
        {
            if (cmbFileType.SelectedItem == null) return;

            string selectedExtension = cmbFileType.SelectedItem.ToString();
            ofdFileSelector.Filter = $"Text Files|*{selectedExtension}";

            if (ofdFileSelector.ShowDialog() == DialogResult.OK)
            {
                string filePath = ofdFileSelector.FileName;
                Log($"File selected: {filePath}");

                try
                {
                    prgProcess.Value = 10;
                    IFileReader reader = GetFileReader(selectedExtension);

                    prgProcess.Value = 40;
                    Log("Reading file content...");
                    string content = await reader.ReadAsync(filePath);

                    prgProcess.Value = 70;
                    Log("Analyzing content...");
                    AnalysisResult result = _analyzer.Analyze(content);

                    prgProcess.Value = 90;
                    UpdateUI(result);

                    prgProcess.Value = 100;
                    Log("Analysis completed successfully.");
                }
                catch (Exception ex)
                {
                    prgProcess.Value = 0;
                    Log($"ERROR: {ex.Message}");
                    MessageBox.Show($"An error occurred:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // --- YARDIMCI METODLAR ---

        private IFileReader GetFileReader(string extension)
        {
            switch (extension)
            {
                case ".txt":
                    return new TxtFileReader();
                case ".docx":
                    return new DocxFileReader();
                case ".pdf":
                    return new PdfFileReader();
                default:
                    throw new NotSupportedException("Unsupported file format.");
            }
        }

        private void UpdateUI(AnalysisResult result)
        {
            lblDistinctWords.Text = $"Total Distinct Words: {result.TotalDistinctWords}";
            lblPunctuations.Text = $"Total Punctuations: {result.TotalPunctuations}";

            dgvFrequencies.Rows.Clear();
            foreach (var kvp in result.WordFrequencies)
            {
                dgvFrequencies.Rows.Add(kvp.Key, kvp.Value);
            }
        }

        private void Log(string message)
        {
            lstLogs.Items.Insert(0, $"[{DateTime.Now:HH:mm:ss}] {message}");
        }
        // --- ÇİFT TIKLAYIP YANLIŞLIKLA AÇTIĞIN, BOŞ KALACAK METODLAR ---
        // Bunları silmiyoruz çünkü tasarım tarafında hata verebilir, boş kalmaları zararsızdır.
    }
}