using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            object ob = null;
            if (ob.Equals(null))
            {
                MessageBox.Show("null");
            }
            else
            {
                MessageBox.Show("not null");
            }

        }
    }
}
