﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 using Compression_Stockings_SWD;

 namespace CompressionStocking
{
    public interface IBtnHandler
    {
        void StartBtnPushed();
        void StopBtnPushed();
    }
    
    public class StockingCtrl : IBtnHandler
    {
        private readonly ICompressionCtrl _compressionCtrl;
        private readonly ILED _LEDCtrlRed;
        private readonly ILED _LEDCtrlGreen;
        private readonly IVibrator _vibratorCtrl;

        public StockingCtrl(ICompressionCtrl compressionCtrl, IVibrator vibratorCtrl, ILED ledCtrlGreen, ILED ledCtrlRed )
        {
            _compressionCtrl = compressionCtrl;
            _vibratorCtrl = vibratorCtrl;
            _LEDCtrlGreen = ledCtrlGreen;
            _LEDCtrlRed = ledCtrlRed;
        }


        // From IBtnHandler
        public void StartBtnPushed()
        {
            if(_compressionCtrl.IsCompressed() == false)
            {
            _LEDCtrlGreen.LEDCompOn();
            _vibratorCtrl.VibratorOn();
            _compressionCtrl.Compress();
            _vibratorCtrl.VibratorOff();
            _LEDCtrlGreen.LEDOff();
            }
            else
            {
                Console.WriteLine("All ready pumped");
            }
        }

        public void StopBtnPushed()
        {
            if(_compressionCtrl.IsCompressed() == true)
            {
            _LEDCtrlRed.LEDDeCompOn();
            _vibratorCtrl.VibratorOn();
            _compressionCtrl.Decompress();
            _vibratorCtrl.VibratorOff();
            _LEDCtrlRed.LEDOff();
            }
            else
            {
                Console.WriteLine("All ready empty");
            }
        }


    }
}
