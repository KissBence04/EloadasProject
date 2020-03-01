using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EloadasProject
{
    public class Eloadas
    {
        private bool [,] foglalasok;
        private int sorokSzama;
        private int helyekSzama;

        public Eloadas(int sorokSzama, int helyekSzama)
        {
            if(helyekSzama>0 && sorokSzama>0)
            {
                foglalasok = new bool[helyekSzama, sorokSzama];
                this.sorokSzama = sorokSzama;
                this.helyekSzama = helyekSzama;
                for (int i = 0; i < sorokSzama; i++)
                {
                    for (int j = 0; j < helyekSzama; j++)
                    {
                        foglalasok[i, j] = false;
                    }
                }
            }
            else
            {
                throw new ArgumentException("Helyek és sorok száma nem lehet 0-nél kisebb");
            }
            
        }

        public bool Lefoglal()
        {
            if(helyekSzama>0)
            {
                for (int i = 0; i < sorokSzama; i++)
                {
                    for (int j = 0; j < helyekSzama; j++)
                    {
                        foglalasok[i,j]=true;
                        return true;
                    }
                }
            }
            return false;
        }

        public int SzabadHelyek {
            get
            {
                int db = 0;
                if (!Teli() && helyekSzama > 0)
                {
                    db++;
                }
                return db;
            }
        }

        public bool Teli()
        {
            return helyekSzama == 0;
        }

        public bool Foglalt(int sorszam, int helySzam)
        {
            if(sorszam > 0 && sorszam<=this.sorokSzama && 
               helySzam>0 && helySzam<=this.helyekSzama)
            {
                return foglalasok[sorszam--,helySzam--];
            }
            return false;
        }

    }
}
