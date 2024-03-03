using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InstrumenteMuzicale
{
    public partial class InstrumenteMuzicale : Form
    {
        public InstrumenteMuzicale()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var newForm = new Chitara();
            newForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var newForm = new Vioara();
            newForm.Show();
        }
    }
}
