using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inheritance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnEnter_Click(object sender, EventArgs e)
        {
            string CAD, FCity, FName, FShippingAdd;
            int Age, FCistID;

            CAD = textBox1.Text;
            Age = Convert.ToInt32(textBox2.Text);
            FCity = textBox3.Text;
            FName = textBox4.Text;
            FCistID = Convert.ToInt32(textBox5.Text);
            FShippingAdd= textBox6.Text;
        }
    }
}
