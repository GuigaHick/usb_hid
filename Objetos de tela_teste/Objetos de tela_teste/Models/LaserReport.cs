using System;
using System.Linq;

namespace Objetos_de_tela_teste.Models
{
    public class LaserReport
    {
        public uint NtcReal { get;  set; } //Ntc

        public uint FinalSignal { get; set; } // Sing Out

        public uint Signal { get;  set; } // Sign In

        public float Current { get;  set; } // Corrent Real

        public void Parse(byte[] data)//It will be fixed as soon as we define how inbound data will be described
        {
            Console.WriteLine($"datacout: {data.Count()}");
            Console.WriteLine($"data8: {data[8]}");
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
            Array.Copy(data, 1, signOut, 0, 2);

            byte[] signIn = new byte[2];
            Array.Copy(data, 3, signIn, 0, 2);

            byte[] ntcIn = new byte[2];
            Array.Copy(data, 7, ntcIn, 0, 2);

            if(BitConverter.IsLittleEndian)
            {
                signOut.Reverse();
                signIn.Reverse();
                ntcIn.Reverse();
            }

            this.FinalSignal = BitConverter.ToUInt16(signOut, 0);

            this.Signal = BitConverter.ToUInt16(signIn, 0);

            this.Current = data[5] + ((float)data[6] / 10);

            this.NtcReal = BitConverter.ToUInt16(ntcIn, 0);
            
            Console.WriteLine($"Sign Out: {signOut[0]} {signOut[1]}");
            Console.WriteLine($"Sign In: {signIn[0]} {signIn[1]}");
            Console.WriteLine($"tcreal: {ntcIn[0]} {ntcIn[1]}");
        }
    }
}
