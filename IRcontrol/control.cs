using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRcontrol
{
    static class control
    {
        static public int mode = 1;//mode. First or Second. Number 0 is all mode(for config only)
        public const int num = 23;
        public const int num_of_button = 21;//number of buttons on IRC. Strt with 0
        static public string[] first = new string[num] {"", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "FFFFFFFF" };
        static public string[] second = new string[num] { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "FFFFFFFF" };
        static public string[,] memory = new string[num_of_button, 3];//First arg - button number, second arg: 0 - code, 1 - id of function, 2 - last mode selected for this button 
        static public void swithMode()
        {
            if (mode == 1) mode = 2;
            else mode = 1;
            
        }
        static public void save()
        {
            ini cfg = new ini(AppDomain.CurrentDomain.BaseDirectory + "/config.ini");
            for(int i = 0; i<num; i++)
            {
                cfg.IniWriteValue("first", i.ToString(), first[i]);
                cfg.IniWriteValue("second", i.ToString(), second[i]);
            }
            for (int i = 0; i < num_of_button; i++)
            {
                cfg.IniWriteValue("memory", "code_" + i.ToString(), memory[i, 0]);
                cfg.IniWriteValue("memory", "funcid_" + i.ToString(), memory[i, 1]);
                cfg.IniWriteValue("memory", "mode_" + i.ToString(), memory[i, 2]);
            }
        }
        static public void load()
        {
            ini cfg = new ini(AppDomain.CurrentDomain.BaseDirectory + "/config.ini");
            for (int i = 0; i < num; i++)
            {
                first[i] = cfg.IniReadValue("first", i.ToString());
                second[i] = cfg.IniReadValue("second", i.ToString());
            }
            for (int i = 0; i < num_of_button; i++)
            {
                memory[i, 0] = cfg.IniReadValue("memory", "code_" + i.ToString());
                memory[i, 1] = cfg.IniReadValue("memory", "funcid_" + i.ToString());
                memory[i, 2] = cfg.IniReadValue("memory", "mode_" + i.ToString());
            }
        }

    }
}
