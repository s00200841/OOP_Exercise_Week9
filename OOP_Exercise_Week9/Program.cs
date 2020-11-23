using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exercise_Week9
{
    class Program
    {
        static void Main(string[] args)
        {
            Song s1 = new Song("ED SHEERAN", "BEAUTIFUL PEOPLE", 3.15, Genre.Pop);
            Song s2 = new Song("REGARD", "RIDE IT", 3.37, Genre.Dance);
            Song s3 = new Song("TONES & I", "DANCE MONKEY", 4.20, Genre.Dance);
            Song s4 = new Song("POST MALONE", "CIRCLES", 3.25, Genre.Pop);
            Song s5 = new Song("ED SHEERAN", "SOUTH OF THE BORDER", 4.26, Genre.Other);
        }
    }
}
