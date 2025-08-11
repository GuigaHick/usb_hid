using System;

namespace Objetos_de_tela_teste.Models
{
    public class LaserConfigRequest
    {
        private const int THRESHOLD1 = 7520;
        private const int THRESHOLD2 = 10640;
        private const int THRESHOLD3 = 13760;
        private const int THRESHOLD4 = 16880;

        public string Name { get; set; }

        public int ID { get; set; }

        public byte MinPowerCurrent { get; set; }

        public byte MaxPowerCurrent { get; set; }

        public byte Increment { get; set; }

        public short NTC { get; set; }

        public short MinNtc {get;set;}

        public short MaxNtc { get;set;}

        public short NtcIncrement { get; set; }

        public float ConvertedTemperature 
        {
            get {return this.ConvertValue(); }
        }


    public byte[] GetByteArray()
        {
            byte[] desiredNtcBytes = BitConverter.GetBytes(NTC);
            byte[] result = new byte[32];
            result[0] = 0x00;
            result[1] = (byte)'L';
            result[2] = (byte)'S';
            result[3] = MinPowerCurrent;
            result[4] = MaxPowerCurrent;
            result[5] = Increment;
            result[6] = desiredNtcBytes[0];
            result[7] = desiredNtcBytes[1];
            result[8] = (byte)ID;

            return result;
        }

    public float ConvertValue()
    {
        var upPart = (float) 3900 * 298.15F;
        var divisionResult = (double)((double)this.NTC / (double)10000);
        var lnR = Math.Log(divisionResult);
        var downPart = (float)((298.15F * lnR) + 3900);
        var firstEquation = (upPart / downPart);
        var finalTemp = firstEquation - 273.15F;

        return finalTemp;
    }

        public int NextNTCIncrement(int currentNTC)
        {
            int result;

            if (currentNTC < THRESHOLD1)
                result = this.NtcIncrement;
            else if (currentNTC < THRESHOLD2)
                result = this.NtcIncrement * 2;
            else if (currentNTC < THRESHOLD3)
                result = this.NtcIncrement * 3;
            else if (currentNTC < THRESHOLD4)
                result = this.NtcIncrement * 4;
            else
                result = 2000; // valor default

            return Math.Min(result, 2000);
        }

    }
}
