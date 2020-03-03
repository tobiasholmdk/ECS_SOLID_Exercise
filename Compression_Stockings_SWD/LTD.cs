using System;
using CompressionStocking;

namespace Compression_Stockings_SWD
{
    public class LTD : ICompressionCtrl
    {
        private bool _isCompressed;
        public void Compress()
        {
            for(int i = 0; i < 40; i++)
            {
                Console.WriteLine("click");
                System.Threading.Thread.Sleep(100);
            }

            _isCompressed = true;
            Console.WriteLine("Done Compressing");
        }

        public void Decompress()
        {
            for(int i = 0; i < 40; i++)
            {
                Console.WriteLine("click");
                System.Threading.Thread.Sleep(100);
            }
            _isCompressed = false;
            Console.WriteLine("Done Decompressing");
        }
        public bool IsCompressed()
        {
            return _isCompressed;
        }
    }
}

