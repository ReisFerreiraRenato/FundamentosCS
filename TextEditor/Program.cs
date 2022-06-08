internal class Program
{
    private static void Main(string[] args)
    {
        Menu();
    }

    static void Menu()
    {
        Console.Clear();
        Console.WriteLine("Editor de Texto");
        Console.WriteLine("1 - Abrir Arquivo");
        Console.WriteLine("2 - Criar novo arquivo");
        Console.WriteLine("0 - Sair");

        short option = short.Parse(Console.ReadLine());

        switch(option)
        {
            case 0: System.Environment.Exit(0); break;
            case 1: Open(); break;
            case 2: Edit(); break; 
        }
    }

    static void Open()
    {
        Console.Clear();
        Console.WriteLine("Qual o caminho do arquivo?");
        string path = Console.ReadLine();

        using (var file = new StreamReader(path))
        {
            string text = file.ReadToEnd();
            Console.WriteLine(text);
        }
        Console.WriteLine("");
        Console.ReadLine();
        Menu();
    }
    static void Edit()
    {

        Console.Clear();
        Console.WriteLine("Digite seu texto abaixo (ESC para sair)");
        Console.WriteLine("---------------------------------------");
        string text = "";

        do{
           text += Console.ReadLine();
           text += "\n";
        } while(Console.ReadKey().Key != ConsoleKey.Escape);
       
       Salvar(text);
    }
    static void Salvar(string text)
    {
        Console.Clear();
        Console.WriteLine("Qual caminho para salvar o arquivo?");
        var path = Console.ReadLine();

        using(var file = new StreamWriter(path))
        {
            file.Write(text);
        }

        Console.WriteLine($"Arquivo {path} salvo com sucesso!");
        Console.ReadLine();
        Menu();
    }
}