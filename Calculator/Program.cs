internal class Program
{
    private static void Main(string[] args)
    {
        Menu();
    }
    static void Menu()
    {
        Cabecalho();
        Console.WriteLine("-     Opções:     -");
        Console.WriteLine("-------------------");
        Console.WriteLine("1 - Soma");
        Console.WriteLine("2 - Subtração");
        Console.WriteLine("3 - Divisão");
        Console.WriteLine("4 - Multiplicação");
        Console.WriteLine("5 - Sair");
        Console.WriteLine("-------------------");

        Console.WriteLine("Selecione uma Opção: ");
        short res = short.Parse(Console.ReadLine());

        switch (res)
        {
            case 1: Soma(); break;
            case 2: Subtracao(); break;
            case 3: Divisao(); break;
            case 4: Multiplicacao(); break;
            case 5: System.Environment.Exit(0); break;
            default: Menu(); break;
        }
    }
    static void Cabecalho()
    {
        Console.Clear();
        Console.WriteLine("-------------------");
        Console.WriteLine("    Calculadora    ");
        Console.WriteLine("-------------------");
    }
    static void Soma()
    {
        Cabecalho();
        Console.WriteLine("-      Soma       -");
        Console.WriteLine("-------------------");
        Console.WriteLine("Primeiro valor: ");
        float v1 = float.Parse(Console.ReadLine());
        Console.WriteLine("Segundo valor: ");
        float v2 = float.Parse(Console.ReadLine());
        Console.WriteLine("");
        // Console.WriteLine("A soma de " + v1 + " + " + v2 + " = " + (v1 + v2));
        Console.WriteLine($"A soma de {v1} + {v2} = {v1 + v2}");
        Console.ReadKey();
        Menu();
    }
    static void Subtracao()
    {
        Cabecalho();
        Console.WriteLine("-    Subtracao    -");
        Console.WriteLine("-------------------");
        Console.WriteLine("Primeiro valor:");
        float v1 = float.Parse(Console.ReadLine());
        Console.WriteLine("Segundo valor:");
        float v2 = float.Parse(Console.ReadLine());
        Console.WriteLine("");
        Console.WriteLine($"A subtração de {v1} - {v2} = {v1 - v2}");
        Console.ReadKey();
        Menu();
    }
    static void Divisao()
    {
        Cabecalho();
        Console.WriteLine("-     Divisão     -");
        Console.WriteLine("-------------------");
        Console.WriteLine("Primeiro Valor:");
        float v1 = float.Parse(Console.ReadLine());
        Console.WriteLine("Segundo Valor:");
        float v2 = float.Parse(Console.ReadLine());

        Console.WriteLine("");
        Console.WriteLine($"A divisão de {v1} / {v2} = {v1/v2}");
        Console.ReadKey();
        Menu();
    }
    static void Multiplicacao()
    {
        Cabecalho();
        Console.WriteLine("-  Multiplicação  -");
        Console.WriteLine("-------------------");
        Console.WriteLine("Primeiro Valor:");
        float v1 = float.Parse(Console.ReadLine());
        Console.WriteLine("Segundo Valor:");
        float v2 = float.Parse(Console.ReadLine());

        Console.WriteLine("");
        Console.WriteLine($"A multiplicacao de {v1} * {v2} = {v1*v2}");
        Console.ReadKey();
        Menu();
    }

}

enum EOperacao
{
    Soma = 1,
    Subtricao = 2,
    Divisao = 3,
    Multiplicacao = 4
}