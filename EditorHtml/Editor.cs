using System;
using System.Text;

namespace EditorHtml
{
    public static class Editor
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("MDOD EDITOR");
            Console.WriteLine("-----------");
            Start();
        }

        public static void Start()
        {
            var file = new StringBuilder();
            do
            {
                file.Append(Console.ReadLine());
                file.Append(Environment.NewLine);    
            } while(Console.ReadKey().Key != ConsoleKey.Escape);
            Console.WriteLine("-----------");
            Console.WriteLine(".Deseja salvar o arquivo?");
            Viewer.Show(file.ToString());
        }
        public static void Open()
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
            Console.WriteLine("Arquivo aberto com sucesso!!!!!");
            Console.ReadLine();
            Menu.Show();
        }
    }
}