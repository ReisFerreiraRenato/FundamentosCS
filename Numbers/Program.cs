using System;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();

        decimal valor = 10.25m;
        /*
        Console.WriteLine(valor.ToString(
            "G",
            System.Globalization.CultureInfo.CreateSpecificCulture("pt-BR")
        ));
        Console.WriteLine(valor.ToString(
            "C",
            System.Globalization.CultureInfo.CreateSpecificCulture("pt-BR")
        ));
        Console.WriteLine(valor.ToString(
            "C",
            System.Globalization.CultureInfo.CreateSpecificCulture("es-ES")
        ));
        Console.WriteLine(valor.ToString(
            "C",
            System.Globalization.CultureInfo.CreateSpecificCulture("en-US")
        ));
        Console.WriteLine(valor.ToString(
            "C",
            System.Globalization.CultureInfo.CreateSpecificCulture("fr-CA")
        ));

        valor = 10536.25m;
        Console.WriteLine(valor.ToString(
            "G", //Genérico
            System.Globalization.CultureInfo.CreateSpecificCulture("pt-BR")
        ));
        Console.WriteLine(valor.ToString(
            "C", //Currency
            System.Globalization.CultureInfo.CreateSpecificCulture("pt-BR")
        ));
        Console.WriteLine(valor.ToString(
            "F", //Precisão maior
            System.Globalization.CultureInfo.CreateSpecificCulture("pt-BR")
        ));
        Console.WriteLine(valor.ToString(
            "N", //Number
            System.Globalization.CultureInfo.CreateSpecificCulture("pt-BR")
        ));
        Console.WriteLine(valor.ToString(
            "P", //Porcentagem
            System.Globalization.CultureInfo.CreateSpecificCulture("pt-BR")
        ));
        Console.WriteLine(valor.ToString(
            "E04", //Cientific
            System.Globalization.CultureInfo.CreateSpecificCulture("pt_BR")
        ));
        */

        valor = 10536.25m;
        Console.WriteLine(
            Math.Round(valor)
        );
        Console.WriteLine(
            Math.Ceiling(valor)
        );
        Console.WriteLine(
            Math.Floor(valor)
        );
        
    }
}