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
        ini port;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            port.IniWriteValue("port", "port", comboBox1.SelectedItem.ToString());
            port.IniWriteValue("port", "boud", comboBox2.SelectedItem.ToString());
            Form form = new Form1(comboBox1.SelectedItem.ToString(), Convert.ToInt32(comboBox2.SelectedItem.ToString(), 10));
            form.Show();
            Hide();
        }

        private void Form3_Shown(object sender, EventArgs e)
        {
            foreach (string s in SerialPort.GetPortNames())
            {
                comboBox1.Items.Add(s);
            }
            port = new ini(AppDomain.CurrentDomain.BaseDirectory + "/config.ini");
            if (port.IniReadValue("port", "port") != "" && port.IniReadValue("port", "boud") != "")
            {
                string _port = port.IniReadValue("port", "port");
                int boud = Convert.ToInt32(port.IniReadValue("port", "boud"), 10);
                for (int i = 0; i < comboBox1.Items.Count; i++)
                {
                    if (comboBox1.Items[i].ToString() == _port)
                    {
                        Form form = new Form1(_port, boud);
                        form.Show();
                        Hide();
                    }
                }
            }
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            foreach (string s in SerialPort.GetPortNames())
            {
                comboBox1.Items.Add(s);
            }
        }
    }
}
