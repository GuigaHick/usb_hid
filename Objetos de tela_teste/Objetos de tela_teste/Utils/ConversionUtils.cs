using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos_de_tela_teste.Utils
{
    public static class ConversionUtils
    {
        public static byte GetConvertedTemperatureFromString(string value)
        {
            return Convert.ToByte(2 * int.Parse(value));
        }

        public static byte GetConvertedTemperatureFromFloatString(string value)
        {
            return Convert.ToByte(2 * float.Parse(value));
        }

        //public static float ConvertNtcToTemperatureValue(short NtcValue)
        public static float ConvertNtcToTemperatureValue(double NtcValue)
        {
            var upPart = (float)3900 * 298.15F;
            var divisionResult = (double)((double)NtcValue / (double)10000);
            var lnR = Math.Log(divisionResult);
            var downPart = (float)((298.15F * lnR) + 3900);
            var firstEquation = (upPart / downPart);
            var finalTemp = firstEquation - 273.15F;

            return finalTemp;
        }
    }
}
