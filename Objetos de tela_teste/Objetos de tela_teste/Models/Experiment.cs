using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos_de_tela_teste.Models
{
    public class Experiment
    {
        public List<LaserInfo> lasers { get; set; }

        public Experiment(int numOfLasers)
        {
            lasers = new List<LaserInfo>();
            for(int i = 0; i < numOfLasers; i++)
            {
                lasers.Add(new LaserInfo());
            }
        }
    }
}
