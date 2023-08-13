using laboratorul_8;
using System;


namespace MyApp
{
    internal class Program
    {

        static void Main(string[] args)
        {
            /* • Un tren este compus din: o locomotiva si mai multe tipuri de vagoane.
                     Locomotiva va avea:
                         - O metoda de pornire, la apelul careia, aceasta va confirma faptul ca a pornit printr-un mesaj afisat in consola;
                         - O metoda de oprire, la apelul careia, aceasta va confirma faptul ca a oprit printr-un mesaj afisat in consola;
                     Vagoanele vor avea masa si anul fabricatiei si vor fi de mai multe tipuri:
                           -Vagoane de marfa, care vor avea:
                                 - tipul marfii (cereale/carbuni/otel) precum si capacitatea in tone;
                           - Vagoane pentru persoane, care vor avea:
                                   -numar de locuri;
                                   -O metoda care va inchide usile si va confirma in consola inchiderea usilor;
                                   -O metoda care va deschide usile si va confirma in consola deschiderea usilor;
                           - Vagoane clasa I, pentru persoane:
                                   -O metoda de pornire a aerului conditionat care va afisa acest lucru pe ecran;
                                   -O metoda de oprire a aerului conditionat care va afisa acest lucru pe ecran;
                Trenul va avea un nume precum si urmatoarele metode:
                    - Adauga vagon.Aceasta metoda va permite adaugarea vagoanelor la tren.
                    - Pleaca din gara.La aceasta comanda, trenul va inchide usile vagoanelor de persoane si va porni locomotiva.
                    - Opreste in gara. La aceasta comanda, trenul va opri locomotiva, va deschide usile vagoanelor de persoane si va opri aerul conditionat in vagoanele clasa 1.
             
               Proiectati clasele, initializati un tren, adaugati-i vagoane si apelati metodele.
            

                  Suplimentar
           Trenul va avea urmatoarele metode/proprietati:
             -NumarDeLocuri;
                  - metoda/proprietate al carei apel va returna numarul total de locuri din vagoanele de persoane precum si cele de clasa 1.
             -SumarMarfa:
                    -metoda/proprietate al carei apel va returna o lista ce va contine capacitatea totala corespunzatoare fiecarei categorii de marfa.
             
            Proiectati clasele, initializati un tren, adaugati-i vagoane, apelati metodele si afisati rezultatele pe ecran  */


            Locomotiva locomot = new Locomotiva();


            Tren tren = new Tren("Accelarat", locomot);
            tren.AdaugaVagon(new VagonPersoane(80, 2023));
            tren.AdaugaVagon(new VagonPersoaneClasa1(60, 2020));

            tren.AdaugaVagon(new VagonMarfa(1985, TipMarfa.Carbuni, 1450));
            tren.AdaugaVagon(new VagonMarfa(1990, TipMarfa.Otel, 1600));


            tren.PornesteDinGara();

            Console.WriteLine("");

            tren.OpresteInGara();

            Console.WriteLine("");

            Console.WriteLine($"Numar total de locuri {tren.NrLocuri}");

            Console.WriteLine("");

            List<Incarcatura> sumarMarfa = tren.GetSumarMarfa();

            foreach (Incarcatura incarc in sumarMarfa)
                Console.WriteLine($"{incarc.TipMarfa}-{incarc.Cantitate}");

        }
    }
}


