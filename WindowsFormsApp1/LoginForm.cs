using System;
using System.Windows.Forms;
using WindowsFormsApp1.Services;

namespace WindowsFormsApp1
{
    public partial class LoginForm : Form
    {
        private AuthService _authService;

        public LoginForm()
        {
            InitializeComponent();
            _authService = new AuthService();

            // Olay bağlantılarını manuel yapıyoruz (Tasarım ekranı patlamasın diye)
            btnLogin.Click += btnLogin_Click;
            lnkRegister.LinkClicked += lnkRegister_LinkClicked;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (_authService.Login(username, password))
            {
                MessageBox.Show("Giriş Başarılı! Hoş geldiniz.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // asıl programımız olan Form1'i göster
                Form1 mainForm = new Form1();
                mainForm.Show();

                // Ekranı gizle
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı kullanıcı adı veya şifre!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lnkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterForm regForm = new RegisterForm();
            regForm.ShowDialog();
        }

    }
}