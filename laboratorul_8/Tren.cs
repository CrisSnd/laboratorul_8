using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratorul_8
{
    internal class Tren
    {
        private readonly string nume;
        private Locomotiva locomotiva;
        private List<Vagon> vagoane = new List<Vagon>();


        public Tren(string nume, Locomotiva locomotiva)
        {
            this.nume = nume;
            this.locomotiva = locomotiva;

        }



        public int NrLocuri
        {
            get
            {
                int nrLocuri = 0;
                foreach (Vagon vag in vagoane)
                {

                    if (vag is VagonPersoane)

                    {
                        nrLocuri += (vag as VagonPersoane).NrPersoane;
                    }

                }

                return nrLocuri;
            }

        }



        public void AdaugaVagon(Vagon vagon)
        {
            vagoane.Add(vagon);

        }


        public List<Incarcatura> GetSumarMarfa()
        {
            List<Incarcatura> rezultat = new List<Incarcatura>();

            foreach (Vagon vag in vagoane)
            {
                if (!(vag is VagonMarfa))
                {
                    continue;

                }

                VagonMarfa vgm = vag as VagonMarfa;
                Incarcatura incarcatura = null;

                foreach (Incarcatura incarcatExistenta in rezultat)
                {
                    if (incarcatExistenta.TipMarfa == vgm.TipMarfa)
                    {
                        incarcatura = incarcatExistenta;
                        break;
                    }
                }

                if (incarcatura != null)
                {
                    incarcatura.Cantitate += vgm.Cantitate;
                }
                else
                {
                    incarcatura = new Incarcatura(vgm.TipMarfa);
                    incarcatura.Cantitate = vgm.Cantitate;
                    rezultat.Add(incarcatura);
                }

            }

            return rezultat;

        }


        public void PornesteDinGara()
        {
            foreach (Vagon vg in vagoane)
            {

                if (vg is VagonPersoaneClasa1)
                {
                    VagonPersoaneClasa1 vagonPersoaneClasa1 = vg as VagonPersoaneClasa1;
                    vagonPersoaneClasa1.InchideUsile();
                    vagonPersoaneClasa1.PornesteAC();
                }


                else if (vg is VagonPersoane)
                {
                    VagonPersoane vagonPersoane = vg as VagonPersoane;
                    vagonPersoane.InchideUsile();
                }


            }

            locomotiva.Porneste();
        }



        public void OpresteInGara()
        {
            locomotiva.Opreste();

            foreach (Vagon vg in vagoane)
            {

                if (vg is VagonPersoaneClasa1)
                {
                    VagonPersoaneClasa1 vagonPersoaneClasa1 = vg as VagonPersoaneClasa1;
                    vagonPersoaneClasa1.OpresteeAC();
                    vagonPersoaneClasa1.DeschideUsile();
                }


                else if (vg is VagonPersoane)
                {
                    VagonPersoane vagonPersoane = vg as VagonPersoane;
                    vagonPersoane.DeschideUsile();
                }


            }

        }

    }
}
