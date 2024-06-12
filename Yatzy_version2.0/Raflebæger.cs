using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yatzy_version2._0
{
    internal class Raflebæger
    {
        public List<Terning> terninger = new List<Terning>();

        Terning t1 = new Terning();
        Terning t2 = new Terning();
        Terning t3 = new Terning();
        Terning t4 = new Terning();
        Terning t5 = new Terning();

        public void VisTerninger()
        {
            int i = 1;
            foreach (Terning terning in terninger)
            {
                Console.WriteLine($"terning{i}: {terning.Værdi}");
                i++;
            }
        }

        public void RystStart()
        {
            terninger.Add(t1);
            terninger.Add(t2);
            terninger.Add(t3);
            terninger.Add(t4);
            terninger.Add(t5);

            foreach (Terning terning in terninger)
            {                
                terning.Ryst();                
            }                        
        }

        public int EtterePoint()
        {
            int ettersum = 0;
            foreach (Terning terning in terninger)
            {
                if (terning.Værdi == 1)
                {
                    ettersum += 1;
                }
            }
            return ettersum;
        }
        
        public int ToerePoint()
        {
            int toersum = 0;
            foreach (Terning terning in terninger)
            {
                if (terning.Værdi == 2)
                {
                    toersum += 2;
                }
            }
            return toersum;
        }

        public int TreerePoint()
        {
            int treersum = 0;
            foreach (Terning terning in terninger)
            {
                if (terning.Værdi == 3)
                {
                    treersum += 3;
                }
            }
            return treersum;
        }

        public int FirerePoint()
        {
            int firersum = 0;
            foreach (Terning terning in terninger)
            {
                if (terning.Værdi == 4)
                {
                    firersum += 4;
                }
            }
            return firersum;
        }

        public int FemmerePoint()
        {
            int femmersum = 0;
            foreach (Terning terning in terninger)
            {
                if (terning.Værdi == 5)
                {
                    femmersum += 5;
                }
            }
            return femmersum;
        }

        public int SekserePoint()
        {
            int seksersum = 0;
            foreach (Terning terning in terninger)
            {
                if (terning.Værdi == 6)
                {
                    seksersum += 6;
                }
            }
            return seksersum;
        }

        public int EtParPoint()
        {
            Dictionary<int, int> parCheck = new Dictionary<int, int>();

            int[] værdier = { t1.Værdi, t2.Værdi, t3.Værdi, t4.Værdi, t5.Værdi };

            foreach (int værdi in værdier)
            {
                if (parCheck.ContainsKey(værdi))
                {
                    parCheck[værdi]++;
                }
                else
                {
                    parCheck[værdi] = 1;
                }
            }

            int højesteParVærdi = 0;

            foreach (var kvp in parCheck)
            {
                if (kvp.Value >= 2 && kvp.Key > højesteParVærdi)
                {
                    højesteParVærdi = kvp.Key;
                }
            }
            
            if (højesteParVærdi > 0)
            {
                return 2 * højesteParVærdi;
            }

            return 0;
        }

        public int ToParPoint()
        {
            Dictionary<int, int> parCheck = new Dictionary<int, int>();

            int[] værdier = { t1.Værdi, t2.Værdi, t3.Værdi, t4.Værdi, t5.Værdi };

            foreach (int værdi in værdier)
            {
                if (parCheck.ContainsKey(værdi))
                {
                    parCheck[værdi]++;
                }
                else
                {
                    parCheck[værdi] = 1;
                }
            }
            
            List<int> par = new List<int>();

            foreach (var kvp in parCheck)
            {
                if (kvp.Value >= 2)
                {
                    par.Add(kvp.Key);
                }
            }

            if (par.Count == 2)
            {
                return 2 * (par[0] + par[1]);
            }

            return 0;
        }

        public int TreEnsPoint()
        {
            Dictionary<int, int> tæller = new Dictionary<int, int>();

            int[] værdier = { t1.Værdi, t2.Værdi, t3.Værdi, t4.Værdi, t5.Værdi };

            foreach (int værdi in værdier)
            {
                if (tæller.ContainsKey(værdi))
                {
                    tæller[værdi]++;
                }
                else
                {
                    tæller[værdi] = 1;
                }
            }
                                 
            foreach (var kvp in tæller)
            {
                if (kvp.Value >= 3)
                {
                    return 3 * kvp.Key;
                }
            }

            return 0;
        }

        public int FireEnsPoint()
        {
            Dictionary<int, int> tæller = new Dictionary<int, int>();

            int[] værdier = { t1.Værdi, t2.Værdi, t3.Værdi, t4.Værdi, t5.Værdi };

            foreach (int værdi in værdier)
            {
                if (tæller.ContainsKey(værdi))
                {
                    tæller[værdi]++;
                }
                else
                {
                    tæller[værdi] = 1;
                }
            }

            foreach (var kvp in tæller)
            {
                if (kvp.Value >= 4)
                {
                    return 4 * kvp.Key;
                }
            }

            return 0;
        }

        public int LilleStraightPoint()
        {
            HashSet<int> terningværdier = new HashSet<int>() { t1.Værdi, t2.Værdi, t3.Værdi, t4.Værdi, t5.Værdi };

            int[] lilleStraight = { 1, 2, 3, 4, 5 };

            foreach (int værdi in lilleStraight)
            {
                if (!terningværdier.Contains(værdi))
                {
                    return 0;
                }
            }

            return 15;
        }

        public int StorStraightPoint()
        {
            HashSet<int> terningværdier = new HashSet<int>() { t1.Værdi, t2.Værdi, t3.Værdi, t4.Værdi, t5.Værdi };

            int[] storStraight = { 2, 3, 4, 5, 6 };

            foreach (int værdi in storStraight)
            {
                if (!terningværdier.Contains(værdi))
                {
                    return 0;
                }
            }

            return 20;
        }

        public int FuldtHusPoint()
        {
            Dictionary<int, int> tæller = new Dictionary<int, int>();

            int[] værdier = { t1.Værdi, t2.Værdi, t3.Værdi, t4.Værdi, t5.Værdi };

            foreach (int værdi in værdier)
            {
                if (tæller.ContainsKey(værdi))
                {
                    tæller[værdi]++;
                }
                else
                {
                    tæller[værdi] = 1;
                }
            }

            bool toEns = false;
            bool treEns = false;
            int toVærdi = 0;
            int treVærdi = 0;            
            
            foreach (var kvp in tæller)
            {
                if (kvp.Value == 2)
                {
                    toEns = true;
                    toVærdi = kvp.Key;
                }
                else if (kvp.Value == 3)
                {
                    treEns = true;
                    treVærdi = kvp.Key;
                }
            }

            if (toEns && treEns)
            {
                return 2 * toVærdi + 3 * treVærdi;
            }

            return 0;
        }

        public int ChancenPoint()
        {
            return t1.Værdi + t2.Værdi + t3.Værdi + t4.Værdi + t5.Værdi;
        }

        public int YatzyPoint()
        {
            Dictionary<int, int> tæller = new Dictionary<int, int>();

            int[] værdier = { t1.Værdi, t2.Værdi, t3.Værdi, t4.Værdi, t5.Værdi };

            foreach (int værdi in værdier)
            {
                if (tæller.ContainsKey(værdi))
                {
                    tæller[værdi]++;
                }
                else
                {
                    tæller[værdi] = 1;
                }
            }

            foreach (var kvp in tæller)
            {
                if (kvp.Value == 5)
                {
                    return 5 * kvp.Key + 50;
                }
            }

            return 0;
        }
    }
}
