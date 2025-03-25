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
    public partial class TokenForm : Form
    {
        private Timer tokenTimer;
        private int remainingSeconds;

        public TokenForm(int tokenLifetime)
        {
            InitializeComponent();
            remainingSeconds = tokenLifetime;
            InitializeTimer();
        }
        private void InitializeTimer()
        {
            tokenTimer = new Timer();
            tokenTimer.Interval = 1000; // 1 saniye
            tokenTimer.Tick += TokenTimer_Tick;
            tokenTimer.Start();
        }
        private void TokenTimer_Tick(object sender, EventArgs e)
        {
            remainingSeconds--;
            lblTokenTimer.Text = $"Token Süresi: {remainingSeconds} saniye";

            if (remainingSeconds <= 0)
            {
                tokenTimer.Stop();
                MessageBox.Show("Oturum süresi doldu. Tekrar giriş yapın.", "Oturum Süresi Bitti", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
        }

        private void lblTokenTimer_Click(object sender, EventArgs e)
        {

        }
    }
}
