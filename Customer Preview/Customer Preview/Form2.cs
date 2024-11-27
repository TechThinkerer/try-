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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        public void SetValues(string name, string country, string gender, string hobby, string status)
        {
            label1.Text = "Name: " + name;
            label2.Text = "Country: " + country;
            label3.Text = "Gender: " + gender;
            label4.Text = "Hobby: " + hobby;
            label5.Text = "Status: " + status;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
