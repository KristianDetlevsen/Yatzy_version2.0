using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yatzy_version2._0
{
    internal class Runde
    {
        Raflebæger raflebæger = new Raflebæger();        

        public void IndtastNavn(Spiller spiller) 
        {
            Console.Write("Indtast navn på spiller: ");                     
            string navn = Console.ReadLine();
            
            if (String.IsNullOrEmpty(navn))
            {
                navn = "Generisk spiller";
            }

            spiller.Navn = navn;            
        }

        public void SpilRunde(Spiller spiller, int rundeNummer)
        {                       
            Console.Write($"Det runde {rundeNummer} og det er nu {spiller.Navn}'s tur. Tryk enter for at kaste terningerne!");
            Console.ReadLine();

            raflebæger.RystStart();
            raflebæger.VisTerninger();

            for (int i = 0; i < 2; i++)
            {
                bool exit = false;

                while (!exit)
                {
                    try
                    {
                        Console.Write("Skriv hvilke terninger, du vil slå om - adskilt med komma (f.eks. 1,3,4) eller bare tryk enter, hvis du ønsker at beholde dine terninger: ");
                        string terningValg = Console.ReadLine();
                        if (String.IsNullOrEmpty(terningValg))
                        {
                            exit = true;
                            return;
                        }

                        string trimmetTerningValg = terningValg.Trim();
                        string[] valg = trimmetTerningValg.Split(",");

                        if (valg.Length == 1)
                        {
                            bool test1 = int.TryParse(valg[0], out int terning1);
                            if (test1)
                            {
                                raflebæger.terninger[terning1 - 1].Ryst();
                                raflebæger.VisTerninger();
                                exit = true;
                            }
                            else
                            {
                                Console.WriteLine("Forsøg ny indtastning - husk at bruge tal adskilt af komma!");
                            }
                        }
                        else if (valg.Length == 2)
                        {
                            bool test1 = int.TryParse(valg[0], out int terning1);
                            bool test2 = int.TryParse(valg[1], out int terning2);
                            if (test1 && test2)
                            {
                                raflebæger.terninger[terning1 - 1].Ryst();
                                raflebæger.terninger[terning2 - 1].Ryst();
                                raflebæger.VisTerninger();
                                exit = true;
                            }
                            else
                            {
                                Console.WriteLine("Forsøg ny indtastning - husk at bruge tal adskilt af komma!");
                            }
                        }
                        else if (valg.Length == 3)
                        {
                            bool test1 = int.TryParse(valg[0], out int terning1);
                            bool test2 = int.TryParse(valg[1], out int terning2);
                            bool test3 = int.TryParse(valg[2], out int terning3);
                            if (test1 && test2 && test3)
                            {
                                raflebæger.terninger[terning1 - 1].Ryst();
                                raflebæger.terninger[terning2 - 1].Ryst();
                                raflebæger.terninger[terning3 - 1].Ryst();
                                raflebæger.VisTerninger();
                                exit = true;
                            }
                            else
                            {
                                Console.WriteLine("Forsøg ny indtastning - husk at bruge tal adskilt af komma!");
                            }
                        }
                        else if (valg.Length == 4)
                        {
                            bool test1 = int.TryParse(valg[0], out int terning1);
                            bool test2 = int.TryParse(valg[1], out int terning2);
                            bool test3 = int.TryParse(valg[2], out int terning3);
                            bool test4 = int.TryParse(valg[3], out int terning4);
                            if (test1 && test2 && test3 && test4)
                            {
                                raflebæger.terninger[terning1 - 1].Ryst();
                                raflebæger.terninger[terning2 - 1].Ryst();
                                raflebæger.terninger[terning3 - 1].Ryst();
                                raflebæger.terninger[terning4 - 1].Ryst();
                                raflebæger.VisTerninger();
                                exit = true;
                            }
                            else
                            {
                                Console.WriteLine("Forsøg ny indtastning - husk at bruge tal adskilt af komma!");
                            }
                        }
                        else if (valg.Length == 5)
                        {
                            bool test1 = int.TryParse(valg[0], out int terning1);
                            bool test2 = int.TryParse(valg[1], out int terning2);
                            bool test3 = int.TryParse(valg[2], out int terning3);
                            bool test4 = int.TryParse(valg[3], out int terning4);
                            bool test5 = int.TryParse(valg[3], out int terning5);
                            if (test1 && test2 && test3 && test4 && test5)
                            {
                                raflebæger.terninger[terning1 - 1].Ryst();
                                raflebæger.terninger[terning2 - 1].Ryst();
                                raflebæger.terninger[terning3 - 1].Ryst();
                                raflebæger.terninger[terning4 - 1].Ryst();
                                raflebæger.terninger[terning5 - 1].Ryst();
                                raflebæger.VisTerninger();
                                exit = true;
                            }
                            else
                            {
                                Console.WriteLine("Forsøg ny indtastning - husk at bruge tal adskilt af komma!");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Noget gik galt - prøv igen!");
                        }
                    }
                    catch (ArgumentOutOfRangeException e)
                    {
                        Console.WriteLine("Terningen med det nr. findes ikke - prøv igen!");
                    }                    
                }               
            }            
        }

        public void TildelPoint(ScoreBoard scoreboard)
        {
            bool exit = false;
            
            while(!exit)
            {
                Console.Write("Skriv bogstavet for kombinationen på scoreboardet, som du ønsker at skrive point til eller strege: ");
                string pointValg = Console.ReadLine();

                switch (pointValg)
                {
                    case "A":
                        if (scoreboard.ErTilgængelig(scoreboard.ettere))
                        {
                            scoreboard.TildelEtterePoint(raflebæger.EtterePoint());
                            exit = true;
                        }
                        else
                        {
                            Console.WriteLine("Etterne er brugt!");                            
                        }
                        break;
                    case "B":
                        if (scoreboard.ErTilgængelig(scoreboard.toere))
                        {
                            scoreboard.TildelToerePoint(raflebæger.ToerePoint());
                            exit = true;
                        }
                        else
                        {
                            Console.WriteLine("Toerne er brugt!");
                        }
                        break;
                    case "C":
                        if (scoreboard.ErTilgængelig(scoreboard.treere))
                        {
                            scoreboard.TildelTreerePoint(raflebæger.TreerePoint());
                            exit = true;
                        }
                        else
                        {
                            Console.WriteLine("Treerne er brugt!");
                        }
                        break;
                    case "D":
                        if (scoreboard.ErTilgængelig(scoreboard.firere))
                        {
                            scoreboard.TildelFirerePoint(raflebæger.FirerePoint());
                            exit = true;
                        }
                        else
                        {
                            Console.WriteLine("Firerne er brugt!");
                        }
                        break;
                    case "E":
                        if (scoreboard.ErTilgængelig(scoreboard.femmere))
                        {
                            scoreboard.TildelFemmerePoint(raflebæger.FemmerePoint());
                            exit = true;
                        }
                        else
                        {
                            Console.WriteLine("Femmerne er brugt!");
                        }
                        break;
                    case "F":
                        if (scoreboard.ErTilgængelig(scoreboard.seksere))
                        {
                            scoreboard.TildelSekserePoint(raflebæger.SekserePoint());
                            exit = true;
                        }
                        else
                        {
                            Console.WriteLine("Sekserne er brugt!");
                        }
                        break;
                    case "G":
                        if (scoreboard.ErTilgængelig(scoreboard.etPar))
                        {
                            scoreboard.TildelEtParPoint(raflebæger.EtParPoint());
                            exit = true;
                        }
                        else
                        {
                            Console.WriteLine("Et par er brugt!");
                        }
                        break;
                    case "H":
                        if (scoreboard.ErTilgængelig(scoreboard.toPar))
                        {
                            scoreboard.TildelToParPoint(raflebæger.ToParPoint());
                            exit = true;
                        }
                        else
                        {
                            Console.WriteLine("To par er brugt!");
                        }
                        break;
                    case "I":
                        if (scoreboard.ErTilgængelig(scoreboard.treEns))
                        {
                            scoreboard.TildelTreEnsPoint(raflebæger.TreEnsPoint());
                            exit = true;
                        }
                        else
                        {
                            Console.WriteLine("Tre ens er brugt!");
                        }
                        break;
                    case "J":
                        if (scoreboard.ErTilgængelig(scoreboard.fireEns))
                        {
                            scoreboard.TildelFireEnsPoint(raflebæger.FireEnsPoint());
                            exit = true;
                        }
                        else
                        {
                            Console.WriteLine("Fire ens er brugt!");
                        }
                        break;
                    case "K":
                        if (scoreboard.ErTilgængelig(scoreboard.lilleStraight))
                        {
                            scoreboard.TildelLilleStraightPoint(raflebæger.LilleStraightPoint());
                            exit = true;
                        }
                        else
                        {
                            Console.WriteLine("Lille straight er brugt!");
                        }
                        break;
                    case "L":
                        if (scoreboard.ErTilgængelig(scoreboard.storStraight))
                        {
                            scoreboard.TildelStorStraightPoint(raflebæger.StorStraightPoint());
                            exit = true;
                        }
                        else
                        {
                            Console.WriteLine("Stor straight er brugt!");
                        }
                        break;
                    case "M":
                        if (scoreboard.ErTilgængelig(scoreboard.fuldtHus))
                        {
                            scoreboard.TildelFuldtHusPoint(raflebæger.FuldtHusPoint());
                            exit = true;
                        }
                        else
                        {
                            Console.WriteLine("Fuldt hus er brugt!");
                        }
                        break;
                    case "N":
                        if (scoreboard.ErTilgængelig(scoreboard.chancen))
                        {
                            scoreboard.TildelChancenPoint(raflebæger.ChancenPoint());
                            exit = true;
                        }
                        else
                        {
                            Console.WriteLine("Chancen er brugt!");
                        }
                        break;
                    case "O":
                        if (scoreboard.ErTilgængelig(scoreboard.yatzy))
                        {
                            scoreboard.TildelYatzyPoint(raflebæger.YatzyPoint());
                            exit = true;
                        }
                        else
                        {
                            Console.WriteLine("Yatzy er brugt!");
                        }
                        break;
                    default:
                        Console.WriteLine("Du skal vælge et af bogstaverne for de forskellige kombinationer");
                        break;
                }
            }          
            
            raflebæger.terninger.Clear();
            Console.Clear();
        }

        public void SlutSpillet(ScoreBoard board1, ScoreBoard board2, Spiller spiller1, Spiller spiller2)
        {
            if (board1.UdregnTotal() > board2.UdregnTotal())
            {
                Console.WriteLine($"Spillet er slut - vinderen blev {spiller1.Navn} med {board1.UdregnTotal()} point!");
            }
            else
            {
                Console.WriteLine($"Spillet er slut - vinderen blev {spiller2.Navn} med {board2.UdregnTotal()} point!");
            }            
        }

        public void SlutSpillet(ScoreBoard board1, ScoreBoard board2, ScoreBoard board3, Spiller spiller1, Spiller spiller2, Spiller spiller3)
        {
            if (board1.UdregnTotal() > board2.UdregnTotal() && board1.UdregnTotal() > board3.UdregnTotal())
            {
                Console.WriteLine($"Spillet er slut - vinderen blev {spiller1.Navn} med {board1.UdregnTotal()} point!");
            }
            else if (board2.UdregnTotal() > board1.UdregnTotal() && board2.UdregnTotal() > board3.UdregnTotal())
            {
                Console.WriteLine($"Spillet er slut - vinderen blev {spiller2.Navn} med {board2.UdregnTotal()} point!");
            }
            else
            {
                Console.WriteLine($"Spillet er slut - vinderen blev {spiller3.Navn} med {board3.UdregnTotal()} point!");
            }
        }

        public void SlutSpillet(ScoreBoard board1, ScoreBoard board2, ScoreBoard board3, ScoreBoard board4, Spiller spiller1, Spiller spiller2, Spiller spiller3, Spiller spiller4)
        {
            if (board1.UdregnTotal() > board2.UdregnTotal() && board1.UdregnTotal() > board3.UdregnTotal() && board1.UdregnTotal() > board4.UdregnTotal())
            {
                Console.WriteLine($"Spillet er slut - vinderen blev {spiller1.Navn} med {board1.UdregnTotal()} point!");
            }
            else if (board2.UdregnTotal() > board1.UdregnTotal() && board2.UdregnTotal() > board3.UdregnTotal() && board2.UdregnTotal() > board4.UdregnTotal())
            {
                Console.WriteLine($"Spillet er slut - vinderen blev {spiller2.Navn} med {board2.UdregnTotal()} point!");
            }
            else if (board3.UdregnTotal() > board1.UdregnTotal() && board3.UdregnTotal() > board2.UdregnTotal() && board3.UdregnTotal() > board4.UdregnTotal())
            {
                Console.WriteLine($"Spillet er slut - vinderen blev {spiller3.Navn} med {board3.UdregnTotal()} point!");
            }
            else
            {
                Console.WriteLine($"Spillet er slut - vinderen blev {spiller4.Navn} med {board4.UdregnTotal()} point!");
            }
        }
    }
}
