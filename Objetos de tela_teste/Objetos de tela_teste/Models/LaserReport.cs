using System;

namespace Objetos_de_tela_teste.Models
{
    public class LaserReport
    {
        public int Temperature { get;  set; }

        public int Signal { get;  set; }

        public int Current { get;  set; }

        public void Parse(byte[] data)//It will be fixed as soon as we define how inbound data will be described
        {
            int adc0;
            adc0 = (int)Convert.ToInt32(data[1]) << 8;
            adc0 += (int)Convert.ToInt32(data[2]);

            this.Signal = (adc0 * 2048) / 1023;
            this.Temperature = data[3];
            this.Current = data[5];
        }
    }
}
