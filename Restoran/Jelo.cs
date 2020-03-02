using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restoran
{
    class Jelo
    {
        string ime;
        int vreme;
        int cena;

        public Jelo () { }
        public Jelo(string ime,int vreme,int cena)
        {
            ime = this.ime;
            vreme = this.vreme;
            cena = this.cena;
        }

        public string getIme()
        {
            return ime;
        }
        public void setIme(string ime)
        {
            this.ime = ime;
        }
        public int getVreme()
        {
            return vreme;
        }
        public void setVreme(int vreme)
        {
            this.vreme = vreme;
        }
        public int getCena()
        {
            return cena;
        }
        public void setCena(int cena)
        {
            this.cena = cena;
        }

        }
    }
