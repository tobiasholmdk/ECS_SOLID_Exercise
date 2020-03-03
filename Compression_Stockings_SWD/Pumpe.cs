using System;
using System.Collections;

namespace CompressionStocking
{
    public class Pumpe : ICompressionCtrl
    {
        private bool _isCompresed;
        public void Compress()
        {
            Console.WriteLine("Pumping");
            System.Threading.Thread.Sleep(5000);
            _isCompresed = true;
            Console.WriteLine("Done");
            }

        public void Decompress()
        {
            Console.WriteLine("De-pumping");
            System.Threading.Thread.Sleep(2000);
            _isCompresed = false;
            Console.WriteLine("Done");
            }

        public bool IsCompressed()
        {
            return _isCompresed;
        }
    }
}