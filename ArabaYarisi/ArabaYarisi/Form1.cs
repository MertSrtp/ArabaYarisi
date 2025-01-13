using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace arabayarisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Timer timer;
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                araba.Left -= 5; // Sola 5 piksel hareket
            }
            else if (e.KeyCode == Keys.D)
            {
                araba.Left += 5; // Sağa 5 piksel hareket
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            araba.Top -= 1;
            if (araba.Bounds.IntersectsWith(araba3.Bounds)|| araba.Bounds.IntersectsWith(araba2.Bounds)
               || araba.Bounds.IntersectsWith(araba1.Bounds) || araba.Bounds.IntersectsWith(araba4.Bounds))
            {
                timer.Stop(); // Timer'ı durdur
                MessageBox.Show("Çarptınız");
                Application.Exit();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer = new Timer
            {
                Interval = 5 // 1000 ms (1 saniye)
            };
            timer.Tick += timer1_Tick; // Timer tetiklenince çalışacak fonksiyonu bağla
            timer.Start(); // Timer'ı başlat
           
        }
    }
}
