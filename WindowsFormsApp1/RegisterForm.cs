using System;
using System.Windows.Forms;
using WindowsFormsApp1.Services;

namespace WindowsFormsApp1
{
    public partial class RegisterForm : Form
    {
        private AuthService _authService;

        public RegisterForm()
        {
            InitializeComponent();
            _authService = new AuthService();

            
            btnRegister.Click += btnRegister_Click;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtRegUsername.Text;
            string password = txtRegPassword.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Kullanıcı adı ve şifre boş olamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_authService.Register(username, password))
            {
                MessageBox.Show("Kayıt başarılı! Şimdi giriş yapabilirsiniz.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // Kayıt ekranını kapat, giriş ekranına geri dön
            }
            else
            {
                MessageBox.Show("Bu kullanıcı adı zaten alınmış. Başka bir tane deneyin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}