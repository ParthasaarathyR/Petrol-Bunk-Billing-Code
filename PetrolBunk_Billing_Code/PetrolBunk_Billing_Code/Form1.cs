using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetrolBunk_Billing_Code
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int total = 0;
            int wheel = 0;
            int oilperml = 5;
            int price = 0;

            listBox1.Items.Clear();
            listBox1.Items.Add("Your Reg.No is:" + textBox1.Text.ToUpper());

            if (radioButton1.Checked)
            {
                wheel = 2;
                listBox1.Items.Add("Your vehicle is : Two wheeler");
            }
            if (radioButton2.Checked)
            {
                wheel = 4;
                listBox1.Items.Add("Your vehicle is : Four wheeler");

            }

            if (comboBox1.SelectedItem.ToString() == "Petrol")
            {
                price = 100;
                listBox1.Items.Add("Your fuel type is: " + comboBox1.SelectedItem.ToString());
            }
            else if (comboBox1.SelectedItem.ToString() == "Diesel")
            {
                price = 80;
                listBox1.Items.Add("Your fuel type is: " + comboBox1.SelectedItem.ToString());
            }
            else if (comboBox1.SelectedItem.ToString() == "Kerosene")
            {
                price = 70;
                listBox1.Items.Add("Your fuel type is: " + comboBox1.SelectedItem.ToString());
            }

            if (checkBox1.Checked)
            {
                int costofAirChecking = 5 * wheel;
                listBox1.Items.Add("Cost for Air Checking: " + costofAirChecking);
                total += costofAirChecking;
            }
            if (checkBox2.Checked)
            {
                int costofFuel = price * (int)numericUpDown1.Value;
                listBox1.Items.Add("Cost for Fuel Checking: " + costofFuel);
                total += costofFuel;
            }
            if (checkBox3.Checked)
            {
                int ml = oilperml * (int)numericUpDown2.Value;
                listBox1.Items.Add("Cost for Oil Checking: " + ml);
                total += ml;
            }

            listBox1.Items.Add("Total amounts is: " + total);
        }
    }
}
