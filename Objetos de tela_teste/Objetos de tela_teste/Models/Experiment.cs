using System;
using System.Collections.Generic;

namespace Objetos_de_tela_teste.Models
{
    public class Experiment
    {
        public List<LaserInfo> lasers { get; set; }// all lasers

        public Experiment(int numOfLasers)//Create n lasers
        {
            lasers = new List<LaserInfo>();
            for(int i = 0; i < numOfLasers; i++)
            {
                lasers.Add(new LaserInfo());
            }
        }

        public void EraseData()//Erase Data
        {
            foreach (var laser in lasers)
            {
                
                laser.reports.Clear();
            }
        }

        internal void Run()
        {
            foreach (var laser in lasers)
            {
                laser.RunProcess();
            }
        }

        internal void Stop()
        {
            foreach (var laser in lasers)
            {
                laser.StopProcess();
            }
        }
    }
}
