using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Objetos_de_tela_teste.Models
{
    public class LaserInfo
    {
        public int ID { get; set; }

        public AutoResetEvent ProcessFinishedEvent { get; set; }

        public LaserConfigRequest InitialRequest { get; set; }

        public int Current { get; set; }

        public int CurrentTemperature { get; set; }

        public int DesiredTemperature { get; set; }

        public int DesiredCurrent { get; set; }

        public List<LaserReport> reports { get; set; }

        public LaserInfo()
        {
            this.ProcessFinishedEvent = new AutoResetEvent(false);
            this.reports = new List<LaserReport>();
        }
    }
}
