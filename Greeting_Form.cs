using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_Itog_Smolnicov
{
    public partial class Greeting_Form : Form
    {
        public Greeting_Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.ShowDialog();
            frm.Dispose();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Вы точно хотите выйти?", "Подтверждение.", MessageBoxButtons.YesNoCancel);
            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
