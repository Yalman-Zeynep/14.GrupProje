using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class Form1 : Form
    {
        private DatabaseHelper dbHelper = new DatabaseHelper();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text;

            if (dbHelper.RegisterUser(email, password))
            {
                MessageBox.Show("Kayıt başarılı!");
            }
            else
            {
                MessageBox.Show("Kayıt başarısız!");
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text;

            if (dbHelper.LoginUser(email, password))
            {
                string token = JwtHelper.GenerateToken(email);
                int tokenLifetime = 60; // Token süresi (saniye)

                MessageBox.Show("Giriş başarılı!\nJWT Token:\n" + token);

                TokenForm tokenForm = new TokenForm(tokenLifetime);
                tokenForm.Show();
            }
            else
            {
                MessageBox.Show("Giriş başarısız!");
            }
        }

       
    }
}
