using csharp_abstract_animals;

Console.WriteLine("cane");
Animale cane = new Cane();
cane.Dormi(); 
cane.Verso(); 
cane.Mangia();

Console.WriteLine();
Console.WriteLine("passerotto");

Animale passerotto = new Passerotto();
passerotto.Dormi();
passerotto.Verso();
passerotto.Mangia();

Console.WriteLine();
Console.WriteLine("aquila");

Animale aquila = new Aquila();
aquila.Dormi();
aquila.Verso();
aquila.Mangia();

Console.WriteLine();
Console.WriteLine("delfino");

Animale delfino = new Delfino();
aquila.Dormi();
delfino.Verso();
delfino.Mangia();

Console.WriteLine();
Console.WriteLine("pulcinelladimare");

Animale pulcinelladimare = new Pulcinelladimare();
pulcinelladimare.Dormi();
pulcinelladimare.Verso();
pulcinelladimare.Mangia();

Console.WriteLine("---------------------------------------");

Console.WriteLine("Aquila:");
FaiVolare((IVolante)aquila);

Console.WriteLine("Delfino:");
FaiNuotare((INuotante)delfino);

static void FaiVolare(IVolante aquila)
{
    aquila.Vola();
}

static void FaiNuotare(INuotante delfino)
{
    delfino.Nuota();
}


Console.WriteLine("Pulcinella di mare:");
FaiVolarePulcinella((IVolante)pulcinelladimare);
FaiNuotarePulcinella((INuotante)pulcinelladimare);

static void FaiVolarePulcinella(IVolante pulcinelladimare)
{
    pulcinelladimare.Vola();
}

static void FaiNuotarePulcinella(INuotante pulcinelladimare)
{
    pulcinelladimare.Nuota();
}