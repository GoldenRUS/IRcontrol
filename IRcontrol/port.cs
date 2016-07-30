using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Threading;

namespace IRcontrol
{
    class port
    {
        static public SerialPort Port;
       /* static public void init(string portname, int rate)
        {
            Port = new SerialPort(portname, rate, Parity.None, 8, StopBits.One);
            Port.Handshake = Handshake.None;
            Port.DataReceived += new SerialDataReceivedEventHandler(new Form1.sp_DataReceived);
        }*/

    }
}
