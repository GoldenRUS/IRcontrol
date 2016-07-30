using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace IRcontrol
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            foreach (string s in SerialPort.GetPortNames())
            {
                comboBox1.Items.Add(s);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            Form form = new Form1(comboBox1.SelectedItem.ToString(), Convert.ToInt32(comboBox2.SelectedItem.ToString(), 10));
            form.Show();
            Hide();
        }
    }
}
