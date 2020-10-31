using System;
using System.Collections.Generic;
using System.Text;

namespace TH3B3
{
    class Time
    {
        private int gio, phut, giay;
        public Time()
        {
            gio = 0;
            phut = 0;
            giay = 0;
        }
        public Time(int gio, int phut, int giay)
        {
            this.gio = gio;
            this.phut = phut;
            this.giay = giay;
        }
        public int Gio
        {
            get
            {
                return Gio;
            }
            set
            {
                Gio = value;
            }
        }
        public int Phut
        {
            get
            {
                return Phut;
            }
            set
            {
                Phut = value;
            }
        }
        public int Giay
        {
            get
            {
                return Giay;
            }
            set
            {
                Giay = value;
            }
        }
    }
}
