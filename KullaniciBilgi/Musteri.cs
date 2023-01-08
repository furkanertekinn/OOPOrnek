using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kapsulleme2
{
    internal class Musteri
    {
        int id;
        string emailAdres;
     
        public string EmailAdres
        {
            get
            {
                return this.emailAdres;
            }
            set
            {
                this.emailAdres = value;
            }
        }

        public Musteri()
        {
            this.id = IDuret();
        }
        public int ID
        {
            get
            {
                return this.id;
            }

            private set
            {
                this.id = value;
            }

        }

        public int IDuret()
        {
            Random rnd = new Random();
            return rnd.Next(1000, 100000);
        }




    }
}
