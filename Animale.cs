﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public abstract class Animale
{
    public void Dormi()
    {
        Console.WriteLine("Zzz");
    }
    public abstract void Verso();
    public abstract void Mangia();
}

