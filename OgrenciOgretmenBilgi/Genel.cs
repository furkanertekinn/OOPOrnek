using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pekistirme
{
    public class Genel
    {
        public string isim { get; set; }
        public string soyisim { get; set; }
        private string TCNo { get; set; }

        public string _tcno
        {
            get
            {
                Console.WriteLine(" ");
                return TCNo;
            }

            set
            {
                if (value.Length == 11)
                {
                    bool inceleme = false;

                    for (int i = 0; i < value.Length; i++)
                    {
                        bool karakterInceleme = char.IsNumber(value[i]);

                        if (karakterInceleme)
                        {

                        }
                        else
                        {
                            inceleme = true;
                            break;
                        }
                    }

                    if (inceleme)
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("TC kimlik numaranız sayısal olmaıdır");
                    }

                    else
                    {
                        this.TCNo = value;
                    }
                }

                else 
                {
                    Console.WriteLine("TC kimlik numaranız 11 haneli olmalıdır !");
                   
                }
            }
        }
    }
}
