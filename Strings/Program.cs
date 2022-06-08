using System.Text;
internal class Program
{
    private static void Main(string[] args)
    {
        /* Guild
        
        var id = Guid.NewGuid();
        id.ToString();
        Console.WriteLine(id);
        id = new Guid("3fa9edf9-e7d4-4234-8adf-c244347771c9");

        if(id != Guid.NewGuid())
            Console.WriteLine("Guid diferêntes");
        Console.WriteLine(id);
        id = new Guid();
        Console.WriteLine(id);*/

        //Interpolação de strings
        /*var price = 10.20;
        // var text = "O preço do produto é " + price + " apenas na promoção";
        // var text = string.Format("O preço do produto é {0} apenas na promoção {1}", price, true);
        var text = $@"O preço do 
            produto é {price} 
            apenas na promoção";
        Console.WriteLine(text);*/

        /*Comparação de strings
        var texto = "Testando";
        Console.WriteLine(texto.CompareTo("Testando"));
        Console.WriteLine(texto.CompareTo("testando"));
        texto = "Este texto é um teste";
        Console.WriteLine(texto.Contains("teste"));
        Console.WriteLine(texto.Contains("Teste"));
        Console.WriteLine(texto.Contains("Teste", StringComparison.OrdinalIgnoreCase));
        // Console.WriteLine(texto.Contains(null)); // valor inválido
        */
        var text = "Este texto é um teste";
        /*
        Console.WriteLine(text.StartsWith("Este"));
        Console.WriteLine(text.StartsWith("este"));
        Console.WriteLine(text.StartsWith("este", StringComparison.OrdinalIgnoreCase));
        Console.WriteLine(text.StartsWith("texto"));
        Console.WriteLine("");
        Console.WriteLine(text.EndsWith("teste"));
        Console.WriteLine(text.EndsWith("Teste"));
        Console.WriteLine(text.EndsWith("Teste", StringComparison.OrdinalIgnoreCase));
        Console.WriteLine(text.EndsWith("xpro"));
        */  
        /*
        //Equals
        Console.WriteLine(text.Equals("Este texto é um teste"));        
        Console.WriteLine(text.Equals("este texto é um teste"));
        Console.WriteLine(text.Equals("Este texto é um teste", StringComparison.OrdinalIgnoreCase));
        */
        /*
        //Índices
        Console.WriteLine(text.IndexOf("é")); 
        Console.WriteLine(text.IndexOf("um"));
        Console.WriteLine(text.LastIndexOf("s"));
        */
        /*
        //Métodos adicionais
        Console.WriteLine(text.ToUpper()); 
        Console.WriteLine(text.ToLower());
        Console.WriteLine(text.Insert(5, "AQUI "));
        Console.WriteLine(text.Remove(5, 6));
        Console.WriteLine(text.Length);
                
        Console.WriteLine(text.Replace("Este","Isto")); 
        Console.WriteLine(text.Replace("e","X"));
        
        var divisao = text.Split(" ");
        Console.WriteLine(divisao[0]);
        Console.WriteLine(divisao[1]);
        Console.WriteLine(divisao[2]);
        Console.WriteLine(divisao[3]);
        Console.WriteLine(divisao[4]);

        var resultado = text.Substring(5, 5);
        Console.WriteLine(resultado);
        resultado = text.Substring(5, text.LastIndexOf("o"));
        Console.WriteLine(resultado);

        text = " Este texto é um teste ";
        Console.WriteLine(text);
        Console.WriteLine(text.Trim());
        */

        //StringBuilder
        text += " aqui";
        Console.WriteLine(text);

        var texto = new StringBuilder();
        texto.Append("Este Texto é um teste");
        texto.Append("Este é um teste");
        texto.Append("Texto é um teste");
        texto.Append("Este Texto é um");
        texto.Append("Este Texto teste");

        texto.ToString();
        Console.WriteLine(texto);
    }
}