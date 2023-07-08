using System;
using System.Linq;

namespace Objetos_de_tela_teste.Models
{
    public class LaserReport
    {
        public uint NTCreal { get;  set; } //Ntc

        public uint SgnOut { get; set; } // Sing Out

        public uint SgnIn { get;  set; } // Sign In

        public float Current { get;  set; } // Corrent Real

        public void Parse(byte[] data)//It will be fixed as soon as we define how inbound data will be described
        {
            Console.WriteLine($"datacout: {data.Count()}");
            Console.WriteLine($"data8: {data[8]}");
          
            byte[] SgnOut = new byte[2];
            Array.Copy(data, 1, SgnOut, 0, 2);

            byte[] SgnIn = new byte[2];
            Array.Copy(data, 3, SgnIn, 0, 2);

            byte[] Current = new byte[2];
            Array.Copy(data, 5, Current, 0, 2);

            byte[] NtcReal = new byte[2];
            Array.Copy(data, 7, NtcReal, 0, 2);


            this.SgnOut = BitConverter.ToUInt16(SgnOut, 0);

            this.SgnIn = BitConverter.ToUInt16(SgnIn, 0);

            this.Current = data[5] + ((float)data[6] / 10);

            this.NTCreal = BitConverter.ToUInt16(NtcReal, 0);
            
            Console.WriteLine($"Sign Out: {SgnOut[0]} {SgnOut[1]}");
            Console.WriteLine($"Sign In: {SgnIn[0]} {SgnIn[1]}");
            Console.WriteLine($"Current: {Current[0]} {Current[1]}");
            Console.WriteLine($"NTCreal: {NtcReal[0]} {NtcReal[1]}");
        }
    }
}
