using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos_de_tela_teste.Models
{
    public class LaserConfigRequest
    {
        public int ID { get; set; }

        public byte MinPowerCurrent { get; set; }

        public byte MaxPowerCurrent { get; set; }

        public byte Increment { get; set; }

        public byte DesiredTemperature { get; set; }

        public byte[] GetByteArray()
        {
            byte[] result = new byte[32];
            result[0] = 0x00;
            result[1] = (byte)'L';
            result[2] = (byte)'S';
            result[3] = MinPowerCurrent;
            result[4] = MaxPowerCurrent;
            result[5] = Increment;
            result[6] = DesiredTemperature;
            result[7] = (byte)ID;
            result[8] = (byte)ID;

            return result;
        }
    }
}
