using System;

namespace Objetos_de_tela_teste.Models
{
    public class LaserConfigRequest
    {
        public string Name { get; set; }

        public int ID { get; set; }

        public byte MinPowerCurrent { get; set; }

        public byte MaxPowerCurrent { get; set; }

        public byte Increment { get; set; }

        public byte DesiredNtc { get; set; }

        public float ConvertedTemperature { get; set; }

        public byte[] GetByteArray()
        {
            byte[] result = new byte[32];
            result[0] = 0x00;
            result[1] = (byte)'L';
            result[2] = (byte)'S';
            result[3] = MinPowerCurrent;
            result[4] = MaxPowerCurrent;
            result[5] = Increment;
            result[6] = DesiredNtc;
            result[7] = (byte)ID;
            result[8] = (byte)ID;

            return result;
        }

        public void ConvertValue()
        {
            this.ConvertedTemperature = (float)((3900 * 298 * 15) / (298 * 15 * Math.Log(DesiredNtc / 1000) + 3900));
        }
    }
}
