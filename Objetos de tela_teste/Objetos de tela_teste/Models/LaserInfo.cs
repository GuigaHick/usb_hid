using System.Collections.Generic;
using System.IO.Ports;
using System.Threading;

namespace Objetos_de_tela_teste.Models
{
    public class LaserInfo
    {
        public string Name { get; set; }

        public int ID { get; set; }

        public AutoResetEvent ProcessFinishedEvent { get; set; }

        public LaserConfigRequest InitialRequest { get; set; }

        public int Current { get; set; }

        public int CurrentTemperature { get; set; }

        public int DesiredNTC { get; set; }

        public int DesiredCurrent { get; set; }

        public List<LaserReport> reports { get; set; }

        public LaserProcessState ProcessState { get; set; } = LaserProcessState.Idle;

        public LaserInfo()
        {
            this.ProcessFinishedEvent = new AutoResetEvent(false);
            this.reports = new List<LaserReport>();
        }

        public void StopProcess()
        {
            this.ProcessState = LaserProcessState.Stopped; this.ProcessFinishedEvent.Set();
        }

        public void RunProcess()
        {
            this.ProcessState = LaserProcessState.Running;
        }
    }

    public enum LaserProcessState
    {
        Running,
        Stopped,
        Finished,
        Idle
    }
}
