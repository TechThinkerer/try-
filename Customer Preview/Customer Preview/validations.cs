using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Customer_Preview
{
    public partial class validations : Form
    {
        public validations()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void customerDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 obj1=new Form1();
            obj1.ShowDialog();
        }
    }
}
