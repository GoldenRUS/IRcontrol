﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRcontrol
{
    static class control
    {
        static public int mode = 1;//mode. First or Second. Number 0 is all mode(for config only)
        public const int num = 22; //number of buttons on IRC. Strt with 0
        static public string[] first = new string[num] {"", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "0xFFFFFFFF\r\n" };
        static public string[] second = new string[num] { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "0xFFFFFFFF" };
        static public string[,] memory = new string[num, 3];//First arg - button number, second arg: 0 - code, 1 - id of function, 2 - last mode selected for this button 
        static public void swithMode()
        {
            if (mode == 1) mode = 2;
            else mode = 1;
            
        }
        static public void save()
        {

        }
        static public void load()
        {

        }

    }
}
