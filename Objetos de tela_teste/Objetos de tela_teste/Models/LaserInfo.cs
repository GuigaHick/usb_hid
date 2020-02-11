using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos_de_tela_teste.Models
{
    public class LaserInfo
    {
        public int ID { get; set; }

        public LaserConfigRequest InitialRequest { get; set; }

        public int Current { get; set; }

        public int CurrentTemperature { get; set; }

        public int DesiredTemperature { get; set; }

        public int DesiredCurrent { get; set; }

        public List<LaserReport> reports = new List<LaserReport>();
    }
}
