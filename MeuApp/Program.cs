using System.Diagnostics;
using MeuApp.Teste;

namespace MeuApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            /*bool? valor = null;

            switch(valor)
            {
                case true: Console.WriteLine("Verdadeiro!"); break;
                case false: Console.WriteLine("Falso!"); break;
                default: Console.WriteLine("Nulo!"); break;
            }*/

           /* for (int i = 1; i < 5; i++)
            {
                Console.WriteLine(i);
            }*/

            /*int valor = 0;
            while (valor <= 5)
            {
                Console.WriteLine(valor);
                valor++;
            }*/

            /*var valor = 0;
            do
            {
                Console.WriteLine("Teste " + valor);
                valor++;
            } while (valor <= 5);*/

            /*MeuMetodo("C# é legal!");
            string nome = RetornaNome("Renato", "Ferreira", 48);
            Console.WriteLine(nome);*/

            var arr = new string[2];
            arr[0] = "Item 1";
            
            var arr2 = arr;

            Console.WriteLine(arr[0]);
            Console.WriteLine(arr2[0]);
            arr[0] = "Item 2";
            Console.WriteLine(arr[0]);
            Console.WriteLine(arr2[0]);

            Console.WriteLine("Finalizou o programa");

        }
        static void MeuMetodo(string parametro)
        {
            for (int i = 1; i <= 5; i++)
                Console.WriteLine(parametro);
        }
        static string RetornaNome(
            string nome, 
            string sobrenome,
            int idade = 34
        )
        {
            return  nome + " " + sobrenome + " tem " + idade;
        }
    }
}