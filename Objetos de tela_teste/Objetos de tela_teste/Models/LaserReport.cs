using System;
using System.Reflection;

namespace Objetos_de_tela_teste.Models
{
    public class LaserReport
    {
        public float NtcReal { get;  set; } //Ntc

        public float FinalSignal { get; set; } // Sing Out

        public float Signal { get;  set; } // Sign In

        public float Current { get;  set; } // Corrent Real

        public void Parse(byte[] data)//It will be fixed as soon as we define how inbound data will be described
        {
            //int adc0;
            //adc0 = (int)Convert.ToInt32(data[1]) << 8;
            //adc0 += (int)Convert.ToInt32(data[2]);

            //this.Signal = (adc0 * 2048) / 1023;
            //this.FinalSignal = ; //Sign Out[0,1]
            //this.Current = data[5] + ((float)data[6] / 10);

            //this.Temperature = data[3] + ((float)data[4] / 10);

            //int adc0;
            //adc0 = (int)Convert.ToInt32(data[1]) << 8;
            //adc0 += (int)Convert.ToInt32(data[2]);

            //this.Signal = (adc0 * 2048) / 1023;


            byte[] signOut = new byte[2];
            Array.Copy(data, 0, signOut, 0, 2);

            byte[] signIn = new byte[2];
            Array.Copy(data, 2, signIn, 0, 2);

            byte[] currentIn = new byte[2];
            Array.Copy(data, 4, currentIn, 0, 2);

            byte[] ntcIn = new byte[2];
            Array.Copy(data, 6, ntcIn, 0, 2);

            this.FinalSignal = Convert.ToSingle(signOut);

            this.Signal = Convert.ToSingle(signIn);

            this.Current = Convert.ToSingle(currentIn);

            this.NtcReal = Convert.ToSingle(ntcIn);
        }
    }
}
