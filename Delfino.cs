﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



public class Delfino : Animale, INuotante
{
    public override void Verso()
    {
        Console.WriteLine("Iiiiii");
    }

    public override void Mangia()
    {
        Console.WriteLine("Pesce");
    }

    public void Nuota()
    {
        Console.WriteLine("Sto nuotando!!!");
    }

}


