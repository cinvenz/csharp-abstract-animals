using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Cane : Animale
{

    public override void Verso()
    {
        Console.WriteLine("Bau");
    }

    public override void Mangia()
    {
        Console.WriteLine("Carne");
    }
}

