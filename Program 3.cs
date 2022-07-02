using System;

namespace If_Else
{
    class Program
    {
        static void Main(string[] args)
        {
            int time = DateTime.Now.Hour;

            if (time >= 6 && time < 14)
            {
                Console.WriteLine("Günaydın");
            }
            else if (time <= 18)
            {
                Console.WriteLine("İyi Günler");
            }
            else
                Console.WriteLine("İyi Geceler");


            string sonuc = time <= 18 ? "İyi Günler" : "İyi Geceler";
            Console.WriteLine(sonuc);

        }
    }

            rakam1 = Int32.Parse(metin1);
            double1 = Double.Parse(metin2);

            Console.WriteLine("rakam1: " + rakam1);
            Console.WriteLine("double1: " + double1);

        }
    }
}
    }
}
