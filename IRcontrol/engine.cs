using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRcontrol
{
    class engine
    {
        private static int last = -1;
        public static void PC_Off()
        {
            System.Diagnostics.Process.Start("cmd.exe", "/C pause");//add "shutdown -s" in release
            last = 0;
        }
        public static void Mute()
        {
            volume.mute();
            last = 1;
        }
        public static void VolP()
        {

        }
        public static void VolM()
        {

        }
        public static void Mouse_Left()
        {

        }
        public static void Mouse_Right()
        {

        }
        public static void Mouse_Up()
        {

        }
        public static void Mouse_Down()
        {

        }
        public static void Mouse_LC()
        {

        }
        public static void Mouse_RC()
        {

        }
        public static void Esc()
        {

        }
        public static void Switch_mode()
        {

        }
        public static void _1()
        {

        }
        public static void _2()
        {

        }
        public static void _3()
        {

        }
        public static void _4()
        {

        }
        public static void _5()
        {

        }
        public static void _6()
        {

        }
        public static void _7()
        {

        }
        public static void _8()
        {

        }
        public static void _9()
        {

        }
        public static void _0()
        {

        }
        public static void pressed()
        {
            System.Diagnostics.Process.Start("cmd.exe", "/C pause");
            Form1.perform(last);
        }      
    }
}
