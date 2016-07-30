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
using System.Threading;

namespace IRcontrol
{
    public partial class Form2 : Form
    {
        public int number;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            InitComboBox();
            //load stat pressed button
            textBox1.Text = control.memory[number, 0];
            comboBox1.SelectedIndex = Convert.ToInt32(control.memory[number, 1], 10);
            comboBox2.SelectedIndex = Convert.ToInt32(control.memory[number, 2], 10);
        }
        private void InitComboBox()//init names of functions in ComboBox
        {
            comboBox1.Items.Clear();
            comboBox1.Items.Add("Off PC"); //id 0
            comboBox1.Items.Add("Mute"); //id 1
            comboBox1.Items.Add("Vol +"); //id 2
            comboBox1.Items.Add("Vol -"); //id 3
            comboBox1.Items.Add("Mouse Left"); //id 4
            comboBox1.Items.Add("Mouse Right"); //id 5
            comboBox1.Items.Add("Mouse Up"); //id 6
            comboBox1.Items.Add("Mouse Down"); //id 7
            comboBox1.Items.Add("Mouse LeftClick"); //id 8
            comboBox1.Items.Add("Mouse RightClick"); //id 9
            comboBox1.Items.Add("Esc"); //id 10
            comboBox1.Items.Add("Switch Mode"); //id 11
            comboBox1.Items.Add("0"); //id 12
            comboBox1.Items.Add("1"); //id 13
            comboBox1.Items.Add("2"); //id 14
            comboBox1.Items.Add("3"); //id 15
            comboBox1.Items.Add("4"); //id 16
            comboBox1.Items.Add("5"); //id 17
            comboBox1.Items.Add("6"); //id 18
            comboBox1.Items.Add("7"); //id 19
            comboBox1.Items.Add("8"); //id 20
            comboBox1.Items.Add("9"); //id 21
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            {
                if (control.mode == 1) control.first[comboBox1.SelectedIndex] = textBox1.Text;
                if (control.mode == 2) control.second[comboBox1.SelectedIndex] = textBox1.Text;
                if (control.mode == 0)
                {
                    control.first[comboBox1.SelectedIndex] = textBox1.Text;
                    control.second[comboBox1.SelectedIndex] = textBox1.Text;
                }

                control.memory[number, 0] = textBox1.Text;
                control.memory[number, 1] = comboBox1.SelectedIndex.ToString();
                control.memory[number, 2] = comboBox2.SelectedIndex.ToString();

                Hide();
            }
            else MessageBox.Show("Select function!", "Error", MessageBoxButtons.OK);
        }
    }
}
