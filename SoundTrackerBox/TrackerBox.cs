using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Media;
using System.Threading;

namespace SoundTrackerBox
{
    class TrackerBox
    {
        

        public void PlayWheepMachine(int length, int delay, string machinearray)
        {
            delay = Math.Abs(delay);
            SoundPlayer letsound;
            char[] letters = machinearray.ToCharArray();
            for(int i = 0; i < length; i++)
            {
                switch (letters[i])
                {
                    case '1':
                        letsound = new SoundPlayer(@"Sounds\SoundTrackerBox\WheepMachine\T-2.wav");
                        Thread.Sleep(delay * 100);
                        letsound.Play();
                        break;
                    case '2':
                        letsound = new SoundPlayer(@"Sounds\SoundTrackerBox\WheepMachine\T-1.wav");
                        Thread.Sleep(delay * 100);
                        letsound.Play();
                        break;
                    case '3':
                        letsound = new SoundPlayer(@"Sounds\SoundTrackerBox\WheepMachine\T1.wav");
                        Thread.Sleep(delay * 100);
                        letsound.Play();
                        break;
                    case '4':
                        letsound = new SoundPlayer(@"Sounds\SoundTrackerBox\WheepMachine\T2.wav");
                        Thread.Sleep(delay * 100);
                        letsound.Play();
                        break;
                    default:
                        Thread.Sleep(delay * 100);
                        break;
                }
            }
        }
        public void PlayBassMachine(int length, int delay, string machinearray)
        {
            delay = Math.Abs(delay);
            SoundPlayer letsound;
            char[] letters = machinearray.ToCharArray();
            for (int i = 0; i < length; i++)
            {
                switch (letters[i])
                {
                    case '1':
                        letsound = new SoundPlayer(@"Sounds\SoundTrackerBox\BassMachine\T-2.wav");
                        Thread.Sleep(delay * 100);
                        letsound.Play();
                        break;
                    case '2':
                        letsound = new SoundPlayer(@"Sounds\SoundTrackerBox\BassMachine\T-1.wav");
                        Thread.Sleep(delay * 100);
                        letsound.Play();
                        break;
                    case '3':
                        letsound = new SoundPlayer(@"Sounds\SoundTrackerBox\BassMachine\T1.wav");
                        Thread.Sleep(delay * 100);
                        letsound.Play();
                        break;
                    case '4':
                        letsound = new SoundPlayer(@"Sounds\SoundTrackerBox\BassMachine\T2.wav");
                        Thread.Sleep(delay * 100);
                        letsound.Play();
                        break;
                    default:
                        Thread.Sleep(delay * 100);
                        break;
                }
            }
        }
    }
}
