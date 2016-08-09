using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRcontrol
{
    class volume
    {
        private static NAudio.CoreAudioApi.MMDeviceEnumerator MMDE;
        private static NAudio.CoreAudioApi.MMDeviceCollection DevCol;
        private static float deflvl =  1.0f;
        private static bool muted = false;


        private static void SetVolume(float level)
        {
            MMDE = new NAudio.CoreAudioApi.MMDeviceEnumerator();
            DevCol = MMDE.EnumerateAudioEndPoints(NAudio.CoreAudioApi.DataFlow.All, NAudio.CoreAudioApi.DeviceState.All);
            foreach (NAudio.CoreAudioApi.MMDevice dev in DevCol)
                {
                    try
                    {
                        if (dev.State == NAudio.CoreAudioApi.DeviceState.Active)
                        {
                            dev.AudioEndpointVolume.MasterVolumeLevelScalar = level;
                            dev.AudioEndpointVolume.Mute = level == 0;
                        }
                    }
                    catch
                    {
                        System.Windows.Forms.MessageBox.Show("Error with set volume", "Error", System.Windows.Forms.MessageBoxButtons.OK);
                    }
                }
         }
         
        public static void mute()
        {
            if(muted)
            {
                SetVolume(deflvl);
                muted = false;
            }else
            {
                SetVolume(0);
                muted = true;
            }
        }
    }
}