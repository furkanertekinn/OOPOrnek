using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pekistirme3
{
    public class dataBase
    {
        ArrayList DB = new ArrayList();

        public ArabaPlakaSorgulama arabaYeniKayit(Araba A)
        {
            DB.Add(A);
            return ArabaPlakaSorgulama.Istanbul;
        }
    }
}
