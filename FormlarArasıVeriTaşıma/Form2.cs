using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormlarArasıVeriTaşıma
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public string mesaj, mesaj2, mesaj3, mesaj4;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = mesaj;
            label2.Text = mesaj2;
            comboBox1.Items.Add(mesaj);
            comboBox1.Items.Add(mesaj2);
            comboBox1.Items.Add(mesaj3);
            comboBox1.Items.Add(mesaj4);

        }
    }
}
