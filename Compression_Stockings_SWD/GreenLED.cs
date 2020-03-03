using System;

namespace Compression_Stockings_SWD
{
    public class GreenLED : ILED
    {
        public void LEDCompOn()
        {
            Console.WriteLine("Green LED ON");
        }

        public void LEDDeCompOn()
        {
            // Do nothing
        }

        public void LEDOff()
        {
            Console.WriteLine("Green LED OFF");
        }

    }
}