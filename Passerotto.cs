using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Passerotto : Animale
{
    public override void Dormi()
    {
        Console.WriteLine("Zzz");
    }

    public override void Verso()
    {
        Console.WriteLine("Chip");
    }

    public override void Mangia()
    {
        Console.WriteLine("Briciole");
    }
}


