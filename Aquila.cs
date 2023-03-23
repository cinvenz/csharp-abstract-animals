using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Aquila : Animale
{
    public override void Dormi()
    {
        Console.WriteLine("Zzz");
    }

    public override void Verso()
    {
        Console.WriteLine("Screech");
    }

    public override void Mangia()
    {
        Console.WriteLine("Carne");
    }
}


