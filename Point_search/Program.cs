using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_search
{
    class Program
    {
        //Nowa linijka

        static bool search(int x1, int y1, int x2, int y2, int xp, int yp)
        {
            if (x1 == x2 && y1 == y2)
            {
                Console.WriteLine("Sciezka znaleziona!");
                return true;
            }
            if (Math.Abs(Math.Abs(x2) - Math.Abs(xp)) < Math.Abs(Math.Abs(x1) - Math.Abs(x2)) ||
                Math.Abs(Math.Abs(y2) - Math.Abs(yp)) < Math.Abs(Math.Abs(y1) - Math.Abs(y2)))
            {
                return false;
            }
            else
            {
                if (search(x1 + y1, y1, x2, y2, x1, y1)) return true;
                if (search(x1, y1 + x1, x2, y2, x1, y1)) return true;
            }
            return false;
        }

        static void Main(string[] args)
        {
            int x1, x2, y1, y2;
            Console.WriteLine("Podaj x poczatkowe: ");
            x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj y poczatkowe: ");
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj x koncowe: ");
            x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj y koncowe: ");
            y2 = Convert.ToInt32(Console.ReadLine());
            if (!search(x1, y1, x2, y2,x1,y1))
            {
                Console.WriteLine("Brak sciezki..");
            }

            Console.ReadKey();
        }
    }
}
