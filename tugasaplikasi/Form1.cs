using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tugasaplikasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnsubmit_click(object sender,EventArgs e)
        {
           
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(textBox4.Text, comboBox3.Text, dateTimePicker1.Text, textBox6.Text);
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.SelectedItem == "PS 1")
            {
                textBox6.Text = "20.000";
            }
            else if (comboBox3.SelectedItem == "PS 2")
            {
                textBox6.Text = "25.000";
            }
            else if (comboBox3.SelectedItem == "PS 3")
            {
                textBox6.Text = "30.000";
            }
            else if (comboBox3.SelectedItem == "PS 4")
            {
                textBox6.Text = "35.000";
            }
            else if (comboBox3.SelectedItem == "PS 5")
            {
                textBox6.Text = "40.000";
            }
        }
    }
}
