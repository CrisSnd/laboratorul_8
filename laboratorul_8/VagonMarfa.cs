using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratorul_8
{
    internal class VagonMarfa :Vagon
    {
        private TipMarfa tipmarfa;
        private int cantitate;

        public VagonMarfa(int anFabricatie, TipMarfa tipmarfa, int cantitate) : base(anFabricatie)
        {

            this.tipmarfa = tipmarfa;
            this.cantitate = cantitate;
        }

        public TipMarfa TipMarfa
        {
            get
            {
                return this.tipmarfa;
            }
        }



        public int Cantitate
        {
            get
            {
                return this.cantitate;
            }
        }
    }
}
