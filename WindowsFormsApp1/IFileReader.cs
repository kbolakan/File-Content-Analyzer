using System.Threading.Tasks;

namespace WindowsFormsApp1.Services // KENDİ PROJE ADINI YAZ
{
    // Başına 'public' yazmak zorunludur, yoksa gizli kalır!
    public interface IFileReader
    {
        Task<string> ReadAsync(string filePath);
    }
}