using System;

namespace Objetos_de_tela_teste.Models
{
    public class LaserReport
    {
        public int Temperature { get;  set; }

        public int Signal { get;  set; }

        public int Current { get;  set; }

        public void Parse(string data)
        {
            string[] txtSplit;
            int adc0, adc4, v1;
            txtSplit = data.Split(' ');
            adc0 = (int)Convert.ToInt32(txtSplit[2]) << 8;
            adc0 += (int)Convert.ToInt32(txtSplit[3]);
            adc4 = (int)Convert.ToInt32(txtSplit[4]);
            v1 = (adc0 * 2048) / 1023;

            this.Signal = v1;
            this.Temperature = adc0;
            this.Current = adc4;
        }
    }
}
