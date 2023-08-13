using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratorul_8
{
    internal class VagonPersoaneClasa1:VagonPersoane
    {
        public VagonPersoaneClasa1(int nrPersoane, int anFabricatie) : base(nrPersoane, anFabricatie)
        {
            base.masa = 30500;

        }

        public void PornesteAC()
        {
            Console.WriteLine("AC-ul porneste");
        }

        public void OpresteeAC()
        {
            Console.WriteLine("AC-ul s-a oprit");
        }
    }
}
