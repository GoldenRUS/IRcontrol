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
    public partial class Form1 : Form
    {
        volume vl = new volume();
        public delegate void Delegate(string data);

        Form2 form2 = new Form2();
        public Form1(string port, int rate)
        {
            InitializeComponent();
            serialPort1.PortName = port;
            serialPort1.BaudRate = rate;
            serialPort1.Open();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            form2.number = 0;
            form2.ShowDialog();
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                Hide();

                IRControl.BalloonTipTitle = "IRControl";
                IRControl.BalloonTipText = "IRControl was hidden. Double click on icon in tray to show.";
                IRControl.ShowBalloonTip(5000); 

            }
        }

        public void swith()
        {
            control.swithMode();
            if (control.mode == 1) panel22.BackgroundImage = Properties.Resources._1;
            if (control.mode == 2) panel22.BackgroundImage = Properties.Resources._2;
        }

        private void perform(int id)
        {
            switch(id)
            {
                case 0:
                    engine.PC_Off();
                    break;
                case 1:
                    engine.Mute();
                    break;
                case 2:
                    engine.VolP();
                    break;
                case 3:
                    engine.VolM();
                    break;
                case 4:
                    engine.Mouse_Left();
                    break;
                case 5:
                    engine.Mouse_Right();
                    break;
                case 6:
                    engine.Mouse_Up();
                    break;
                case 7:
                    engine.Mouse_Down();
                    break;
                case 8:
                    engine.Mouse_LC();
                    break;
                case 9:
                    engine.Mouse_RC();
                    break;
                case 10:
                    engine.Esc();
                    break;
                case 11:
                    engine.Switch_mode();
                    break;
                case 12:
                    engine._0();
                    break;
                case 13:
                    engine._1();
                    break;
                case 14:
                    engine._2();
                    break;
                case 15:
                    engine._3();
                    break;
                case 16:
                    engine._4();
                    break;
                case 17:
                    engine._5();
                    break;
                case 18:
                    engine._6();
                    break;
                case 19:
                    engine._7();
                    break;
                case 20:
                    engine._8();
                    break;
                case 21:
                    engine._9();
                    break;
                case 22:
                    engine.pressed();
                    break;
                case 23:
                    engine.zero();
                    break;
                default:
                    break;
            }
        }

        public void getDatainUI(string data)
        {
            
                if (form2.Created)
                {
                    form2.textBox1.Text = data;
                }
                else
                {
                    int id = -1;
                    if (control.mode == 1 && control.first != null) id = Array.FindIndex(control.first, s => s.Equals(data));
                    if (control.mode == 2 && control.second != null) id = Array.FindIndex(control.second, s => s.Equals(data));
                    if (id >= 0)
                    {
                    perform(id);
                    }
                }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            string indata = sp.ReadExisting();
            BeginInvoke(new Delegate(getDatainUI), indata);
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void panel22_Click(object sender, EventArgs e)
        {
            swith();
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            form2.number = 1;
            form2.ShowDialog();
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            form2.number = 2;
            form2.ShowDialog();
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            form2.number = 3;
            form2.ShowDialog();
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            form2.number = 4;
            form2.ShowDialog();
        }

        private void panel6_Click(object sender, EventArgs e)
        {
            form2.number = 5;
            form2.ShowDialog();
        }

        private void panel7_Click(object sender, EventArgs e)
        {
            form2.number = 6;
            form2.ShowDialog();
        }

        private void panel8_Click(object sender, EventArgs e)
        {
            form2.number = 7;
            form2.ShowDialog();
        }

        private void panel9_Click(object sender, EventArgs e)
        {
            form2.number = 8;
            form2.ShowDialog();
        }

        private void panel10_Click(object sender, EventArgs e)
        {
            form2.number = 9;
            form2.ShowDialog();
        }

        private void panel11_Click(object sender, EventArgs e)
        {
            form2.number = 10;
            form2.ShowDialog();
        }

        private void panel12_Click(object sender, EventArgs e)
        {
            form2.number = 11;
            form2.ShowDialog();
        }

        private void panel13_Click(object sender, EventArgs e)
        {
            form2.number = 12;
            form2.ShowDialog();
        }

        private void panel14_Click(object sender, EventArgs e)
        {
            form2.number = 13;
            form2.ShowDialog();
        }

        private void panel15_Click(object sender, EventArgs e)
        {
            form2.number = 14;
            form2.ShowDialog();
        }

        private void panel16_Click(object sender, EventArgs e)
        {
            form2.number = 15;
            form2.ShowDialog();
        }

        private void panel17_Click(object sender, EventArgs e)
        {
            form2.number = 16;
            form2.ShowDialog();
        }

        private void panel18_Click(object sender, EventArgs e)
        {
            form2.number = 17;
            form2.ShowDialog();
        }

        private void panel19_Click(object sender, EventArgs e)
        {
            form2.number = 18;
            form2.ShowDialog();
        }

        private void panel20_Click(object sender, EventArgs e)
        {
            form2.number = 19;
            form2.ShowDialog();
        }

        private void panel21_Click(object sender, EventArgs e)
        {
            form2.number = 20;
            form2.ShowDialog();
        }
    }
}
