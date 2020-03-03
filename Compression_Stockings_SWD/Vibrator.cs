using System;

namespace Compression_Stockings_SWD
{
    public class Vibrator : IVibrator
    {
        public void VibratorOn()
        {
            Console.WriteLine("Vibrating");
        }

        public void VibratorOff()
        {
            Console.WriteLine("Not vibrating anymore");
        }
    }
}