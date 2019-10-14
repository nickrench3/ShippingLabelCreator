using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShippingLabel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            NameTextBox1.AppendText("Nick Rentschler");
            StreetTextBox1.AppendText("1136 South Clay");
            CityTextBox1.AppendText("Jacksonville");
            StateComboBox1.Text = "IL";
            ZIPTextBox1.AppendText("62650");
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            string message = "Shipping Label Created";
            string title = "Shipping Label Message";
            MessageBox.Show(message, title);

            // info about sender
            String NameS = NameTextBox1.Text;
            String StreetS = StreetTextBox1.Text;
            String CityNameS = CityTextBox1.Text;
            String StateNameS = StateComboBox1.Text;
            String ZIPCodeS = ZIPTextBox1.Text;

            NameS = NameS.Trim();
            StreetS = StreetS.Trim();
            CityNameS = CityNameS.Trim();

            LabelTextBox.Clear();
            LabelTextBox.AppendText(NameS + Environment.NewLine + StreetS + Environment.NewLine + CityNameS + ", " + StateNameS + " " + ZIPCodeS);

            // info about receiver 
            String NameR = NameTextBox2.Text;
            String StreetR = StreetTextBox2.Text;
            String CityNameR = CityTextBox2.Text;
            String StateNameR = StateComboBox2.Text;
            String ZIPCodeR = ZIPTextBox2.Text;

            NameR = NameR.Trim();
            StreetR = StreetR.Trim();
            CityNameR = CityNameR.Trim();

            LabelTextBox.AppendText(Environment.NewLine + Environment.NewLine + "                                                           " +
                NameR + Environment.NewLine + "                                                           " + StreetR + Environment.NewLine +
                "                                                           " + CityNameR + ", " + StateNameR + " " + ZIPCodeR);
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            if (printDialog1.ShowDialog() == DialogResult.OK)
                printDocument1.Print();
        }

        private void clrbutton1_Click(object sender, EventArgs e)
        {
            NameTextBox1.Text = "";
            StreetTextBox1.Text = "";
            CityTextBox1.Text = "";
            StateComboBox1.Text = "";
            ZIPTextBox1.Text = "";
        }

        private void clrbutton2_Click(object sender, EventArgs e)
        {
            NameTextBox2.Text = "";
            StreetTextBox2.Text = "";
            CityTextBox2.Text = "";
            StateComboBox2.Text = "";
            ZIPTextBox2.Text = "";
        }

        private void printDocument1_PrintPage_1(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(LabelTextBox.Text, new Font("Times New Roman", 12,FontStyle.Bold), Brushes.Black, new PointF(100, 100));
        }
    }
}
