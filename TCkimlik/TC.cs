using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KapsullemeOdev
{
    internal class TC
    {
        private string tckimliknumarasi;

        public string TcKimlikNumarasi
        {
            get
            {
                Console.WriteLine(" ");
                return tckimliknumarasi.Substring(0, 3);
            }

            set
            {
                if (value.Length == 11)
                {
                    bool kontrol = false;

                    for (int i = 0; i < value.Length; i++)
                    {
                        bool karakterKontrol = char.IsNumber(value[i]);

                        if (karakterKontrol)
                        {

                        }

                        else
                        {
                            kontrol = true;
                            break;
                        }
                    }

                    if (kontrol)
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("TC kimlik numarası içindeki değerler sayısal olmalıdır!");
                    }

                    else
                    {
                        this.tckimliknumarasi = value;
                    }

                }

                else
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("TC kimlik numaranız 11 haneli olmalıdır!");
                }
            }

        }


    }
}
