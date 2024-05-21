using System;

interface IPais
{
    string ColorBandera();
    string Tamaño();
    string IdiomaOficial();
}

class Ecuador : IPais
{
    public string ColorBandera()
    {
        return "Amarillo, azul y rojo";
    }

    public string Tamaño()
    {
        return "283,561 km²";
    }

    public string IdiomaOficial()
    {
        return "Español";
    }
}

class Brasil : IPais
{
    public string ColorBandera()
    {
        return "Verde y amarillo";
    }

    public string Tamaño()
    {
        return "8,515,767 km²";
    }

    public string IdiomaOficial()
    {
        return "Portugués";
    }
}

class Andorra : IPais
{
    public string ColorBandera()
    {
        return "Azul, amarillo y rojo";
    }

    public string Tamaño()
    {
        return "468 km²";
    }

    public string IdiomaOficial()
    {
        return "Catalán";
    }
}

class Program
{
    static void Main(string[] args)
    {
        IPais ecuador = new Ecuador();
        IPais brasil = new Brasil();
        IPais andorra = new Andorra();

        Console.WriteLine("Color de la bandera de Ecuador: " + ecuador.ColorBandera());
        Console.WriteLine("Tamaño de Andorra: " + andorra.Tamaño());
        Console.WriteLine("Idioma oficial de Brasil: " + brasil.IdiomaOficial());
    }
}
