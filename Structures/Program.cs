namespace Structures
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var mouse = new Product(1, "Mouse gamer", 299.97, EProductType.Product);
            var manutencaoEletrica = new Product(2, "Manutenção elétrica residencial", 500, EProductType.Service);

            mouse.Id = 55;
            Console.WriteLine(mouse.Id);
            Console.WriteLine(mouse.Name);
            Console.WriteLine(mouse.Price);
            Console.WriteLine(mouse.Type);
            Console.WriteLine((int)mouse.Type);
        }
    }
    struct Product
    {
        public int Id;
        public string Name;
        public double Price;
        public EProductType Type;
        
        public Product(int id, string name, double price, EProductType type)
        {
            Id = id;
            Name = name;
            Price = price;
            Type = type;
        }

        public double PriceInDolar(double dolar)
        {
            return Price * dolar;
        }
    }
    enum EEstadoCivil
    {
        Solteiro = 1,
        Casado = 2,
        Divorciado = 3
    }
    struct Cliente
    {
        public string Nome;
        public EEstadoCivil EstadoCivil;
    }
    enum EProductType
    {
        Product = 1,
        Service = 2
    }
}