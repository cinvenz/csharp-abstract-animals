using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    internal class Pulcinelladimare : Animale , IVolante ,INuotante
    {
        public override void Verso()
        {
            Console.WriteLine("Chip");
        }

        public override void Mangia()
        {
            Console.WriteLine("Pesce");
        }

        public void Vola()
        {
            Console.WriteLine("Sto volando!!!");
        }

        public void Nuota()
        {
            Console.WriteLine("Sto nuotando!!!");
        }

    }
}
