using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.Services
{
    public class AuthService
    {
        // Kullanıcıların kaydedileceği dosya
        private readonly string _dbPath = "users.json";

        //kullanıcı kaydetme metodu
        public bool Register(string username, string password)
        {
            var users = GetAllUsers();

            //Bu kullanıcı adı zaten var mı?
            foreach (var u in users)
            {
                if (u.Username == username) return false;
            }

            //yeni kullanıcıyı listeye ekle ve dosyaya kaydet
            users.Add(new User { Username = username, Password = password });

            string jsonString = JsonSerializer.Serialize(users, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(_dbPath, jsonString);

            return true;
        }

        // Giriş yapma
        public bool Login(string username, string password)
        {
            var users = GetAllUsers();

            foreach (var u in users)
            {
                if (u.Username == username && u.Password == password)
                {
                    return true;
                }
            }
            return false;
        }

        //dosyadaki tüm kullanıcıları okuma metodu
        private List<User> GetAllUsers()
        {
            if (!File.Exists(_dbPath))
            {
                return new List<User>();
            }

            string jsonString = File.ReadAllText(_dbPath);
            if (string.IsNullOrWhiteSpace(jsonString)) return new List<User>();

            return JsonSerializer.Deserialize<List<User>>(jsonString);
        }
    }
}