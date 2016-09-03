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
        public static float step = 0.05f;//volume step, 0.05f = 5%

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
                        System.Windows.Forms.MessageBox.Show("Error with setting volume", "Error", System.Windows.Forms.MessageBoxButtons.OK);
                    }
                }
         }

        private static float GetVolume()
        {
            MMDE = new NAudio.CoreAudioApi.MMDeviceEnumerator();
            DevCol = MMDE.EnumerateAudioEndPoints(NAudio.CoreAudioApi.DataFlow.All, NAudio.CoreAudioApi.DeviceState.All);
            foreach (NAudio.CoreAudioApi.MMDevice dev in DevCol)
            {
                try
                {
                    if (dev.State == NAudio.CoreAudioApi.DeviceState.Active)
                    {
                        return dev.AudioEndpointVolume.MasterVolumeLevelScalar;
                    }
                }
                catch
                {
                    System.Windows.Forms.MessageBox.Show("Error with getting volume", "Error", System.Windows.Forms.MessageBoxButtons.OK);
                    
                }
            }
            return -1;
        }
        
        public static void plus()
        {
            float vol = GetVolume();
            if(vol != -1 && vol <= 1.0f-step)
            {
                SetVolume(vol + step);
            }
        }

        public static void minus()
        {
            float vol = GetVolume();
            if (vol != -1 && vol >= 0.0f + step)
            {
                SetVolume(vol - step);
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
                deflvl = GetVolume();
                SetVolume(0);
                muted = true;
            }
        }
    }
}