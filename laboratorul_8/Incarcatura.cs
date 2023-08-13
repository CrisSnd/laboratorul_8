using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratorul_8
{
    internal class Incarcatura
    {
        public int Cantitate { get; set; }
        public TipMarfa TipMarfa { get; private set; }


        public Incarcatura(TipMarfa tipMarfa)
        {
            this.TipMarfa = tipMarfa;

        }
    }
}
