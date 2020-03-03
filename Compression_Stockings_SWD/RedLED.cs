using System;

namespace Compression_Stockings_SWD
{
    public class RedLED : ILED
    {
        public void LEDCompOn()
        {
            // Do nothing
        }

        public void LEDDeCompOn()
        {
            Console.WriteLine("RED LED ON");
        }

        public void LEDOff()
        {
            Console.WriteLine("RED LED OFF");
        }

    }
}