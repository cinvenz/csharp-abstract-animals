using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Passerotto : Animale, IVolante
{

    public override void Verso()
    {
        Console.WriteLine("Chip");
    }

    public override void Mangia()
    {
        Console.WriteLine("Briciole");
    }

    public void Vola()
    {
        Console.WriteLine("Sto nuotando!!!");
    }

}


