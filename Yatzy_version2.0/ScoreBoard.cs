using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yatzy_version2._0
{
    public class ScoreBoard
    {
        public string ettere = "-";
        public string toere = "-";
        public string treere = "-";
        public string firere = "-";
        public string femmere = "-";
        public string seksere = "-";
        public string etPar = "-";
        public string toPar = "-";
        public string treEns = "-";
        public string fireEns = "-";
        public string lilleStraight = "-";
        public string storStraight = "-";
        public string fuldtHus = "-";
        public string chancen = "-";
        public string yatzy = "-";

               
        public void VisScoreBoard(Spiller spiller)
        {
            Console.WriteLine("");
            Console.WriteLine($"Scoreboard for {spiller.Navn}:");
            Console.WriteLine("--------------------------");
            Console.WriteLine($"A) Ettere:\t\t{ettere}");
            Console.WriteLine($"B) Toere:\t\t{toere}");
            Console.WriteLine($"C) Treere:\t\t{treere}");
            Console.WriteLine($"D) Firere:\t\t{firere}");
            Console.WriteLine($"E) Femmere:\t\t{femmere}");
            Console.WriteLine($"F) Seksere:\t\t{seksere}");
            Console.WriteLine($"Bonus:\t\t\t{TildelBonus()}");
            Console.WriteLine("--------------------------");
            Console.WriteLine($"G) Et par:\t\t{etPar}");
            Console.WriteLine($"H) To par:\t\t{toPar}");
            Console.WriteLine($"I) Tre ens:\t\t{treEns}");
            Console.WriteLine($"J) Fire ens:\t\t{fireEns}");
            Console.WriteLine($"K) Lille straight:\t{lilleStraight}");
            Console.WriteLine($"L) Stor straight:\t{storStraight}");
            Console.WriteLine($"M) Fuldt hus:\t\t{fuldtHus}");
            Console.WriteLine($"N) Chancen:\t\t{chancen}");
            Console.WriteLine($"O) Yatzy:\t\t{yatzy}");
            Console.WriteLine("--------------------------");
            Console.WriteLine($"Total =\t\t\t{UdregnTotal()}");
            Console.WriteLine("");
        }

        public int UdregnTotal()
        {
            int ettereTotal = 0;
            int toereTotal = 0;
            int treereTotal = 0;
            int firereTotal = 0;
            int femmereTotal = 0;
            int seksereTotal = 0;
            int etParTotal = 0;
            int toParTotal = 0;
            int treEnsTotal = 0;
            int fireEnsTotal = 0;
            int lilleStraightTotal = 0;
            int storStraightTotal = 0;
            int fuldtHusTotal = 0;
            int chancenTotal = 0;
            int yatzyTotal = 0;
            
            if (ettere != "-")
                ettereTotal = int.Parse(ettere);
            if (toere != "-")
                toereTotal = int.Parse(toere);
            if (treere != "-")
                treereTotal = int.Parse(treere);
            if (firere != "-")
                firereTotal = int.Parse(firere);
            if (femmere != "-")
                femmereTotal = int.Parse(femmere);
            if (seksere != "-")
                seksereTotal = int.Parse(seksere);
            if (etPar != "-")
                etParTotal = int.Parse(etPar);
            if (toPar != "-")
                toParTotal = int.Parse(toPar);
            if (treEns != "-")
                treEnsTotal = int.Parse(treEns);
            if (fireEns != "-")
                fireEnsTotal = int.Parse(fireEns);
            if (lilleStraight != "-")
                lilleStraightTotal = int.Parse(lilleStraight);
            if (storStraight != "-")
                storStraightTotal = int.Parse(storStraight);
            if (fuldtHus != "-")
                fuldtHusTotal = int.Parse(fuldtHus);
            if (chancen != "-")
                chancenTotal = int.Parse(chancen);
            if (yatzy != "-")
                yatzyTotal = int.Parse(yatzy);
            return ettereTotal + toereTotal + treereTotal + firereTotal + femmereTotal + seksereTotal + TildelBonus() + etParTotal + toParTotal + treEnsTotal + fireEnsTotal + lilleStraightTotal + storStraightTotal + fuldtHusTotal + chancenTotal + yatzyTotal;
        }

        public int TildelBonus()
        {
            int ettereTotal = 0;
            int toereTotal = 0;
            int treereTotal = 0;
            int firereTotal = 0;
            int femmereTotal = 0;
            int seksereTotal = 0;

            if (ettere != "-")
                ettereTotal = int.Parse(ettere);
            if (toere != "-")
                toereTotal = int.Parse(toere);
            if (treere != "-")
                treereTotal = int.Parse(treere);
            if (firere != "-")
                firereTotal = int.Parse(firere);
            if (femmere != "-")
                femmereTotal = int.Parse(femmere);
            if (seksere != "-")
                seksereTotal = int.Parse(seksere);
            int total = ettereTotal + toereTotal + treereTotal + firereTotal + femmereTotal + seksereTotal;
            if (total >= 63)
            {
                return 50;
            }
            else
            {
                return 0;
            }
        }

        public bool ErTilgængelig(string kombination)
        {
            if (kombination == "-")
                return true;
            else
                return false;
        }              
                      
        public void TildelEtterePoint(int point)
        {
            ettere = point.ToString();
        }

        public void TildelToerePoint(int point)
        {
            toere = point.ToString();
        }

        public void TildelTreerePoint(int point)
        {
            treere = point.ToString();
        }

        public void TildelFirerePoint(int point)
        {
            firere = point.ToString();
        }

        public void TildelFemmerePoint(int point)
        {
            femmere = point.ToString();
        }

        public void TildelSekserePoint(int point)
        {
            ettere = point.ToString();
        }

        public void TildelEtParPoint(int point)
        {
            etPar = point.ToString();
        }

        public void TildelToParPoint(int point)
        {
            toPar = point.ToString();
        }

        public void TildelTreEnsPoint(int point)
        {
            treEns = point.ToString();
        }

        public void TildelFireEnsPoint(int point)
        {
            fireEns = point.ToString();
        }

        public void TildelLilleStraightPoint(int point)
        {
            lilleStraight = point.ToString();
        }

        public void TildelStorStraightPoint(int point)
        {
            storStraight = point.ToString();
        }

        public void TildelFuldtHusPoint(int point)
        {
            fuldtHus = point.ToString();
        }

        public void TildelChancenPoint(int point)
        {
            chancen = point.ToString();
        }

        public void TildelYatzyPoint(int point)
        {
            yatzy = point.ToString();
        }
    }
}
