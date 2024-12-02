using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEğitimKampı301.EFProject
{
    public partial class FrmAnaMenü : Form
    {
        public FrmAnaMenü()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            // Yeni bir Form2 örneği oluştur ve göster
            Form1 form1 = new Form1();
            form1.Show();

            //FrmAnaMenü Gizlendi
            this.Hide();

        }

        private void button4_Click(object sender, EventArgs e)
        {
           FrmLocation frmLocation = new FrmLocation();
            frmLocation.Show();

            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {FrmStatistics frmStatistics = new FrmStatistics();
            frmStatistics.Show();

            this.Hide();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
