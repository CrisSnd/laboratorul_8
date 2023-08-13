using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratorul_8
{
    internal class VagonPersoane:Vagon
    {
        private int nrPersoane;


        public VagonPersoane(int nrPersoane, int anFabricatie) : base(anFabricatie)
        {

            base.masa = 20500;
            this.nrPersoane = nrPersoane;

        }

        public void InchideUsile()
        {
            Console.WriteLine("Inchide Usile");
        }

        public void DeschideUsile()
        {
            Console.WriteLine("Deschide Usile");
        }


        public int NrPersoane
        {
            get
            {
                return nrPersoane;
            }
        }
    }
}
