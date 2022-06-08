namespace DotnetLists
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Clear();

            /*var meuArray =  new int[5]{1, 2, 3, 4, 5};
           
            var structArray = new Funcionario[2];

            structArray[0].Id = 99;
            structArray[0].Nome = "João";
            structArray[1].Id = 1025;
            structArray[1].Nome = "Pedro";

            // int[] meuArray =  new int[5];
            meuArray[0] = 12;
            meuArray[1] = 15;

            Console.WriteLine(meuArray[0]);
            Console.WriteLine(meuArray[1]);
            Console.WriteLine(meuArray[2]);
            Console.WriteLine(meuArray[3]);
            Console.WriteLine(meuArray[4]);
            Console.WriteLine("");
            Console.WriteLine(structArray[0].Id);
            Console.WriteLine(structArray[1].Id);

            for (int index = 0; index < meuArray.Length; index++)
                Console.WriteLine(meuArray[index]);
            Console.WriteLine("");
            foreach (var item in meuArray)
                Console.WriteLine(item);
            Console.WriteLine("");
            foreach (var item in structArray)
            {
                Console.WriteLine(item.Id);
                Console.WriteLine(item.Nome);
            }
            */
            var primeiro = new int[4]{ 1, 2, 3, 4};
            // var segundo = primeiro; //Utiliza a referência de memória
            
            var segundo = new int[4];

            segundo[3] = primeiro[0];

            primeiro[0] = 23;
            Console.WriteLine(segundo[3]);
        }
    }
    public struct Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
    }
}