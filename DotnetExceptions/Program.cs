internal class Program
{
    private static void Main(string[] args)
    {
        var arr = new int[3];
        Console.Clear();
        try
        {
            // for (var index = 0; index < 10; index++)
            // {
            //     //IndexOutOfRangeException
            //     Console.WriteLine(arr[index]);
            // }
            Cadastrar("");
        } 
        catch (IndexOutOfRangeException ex) //Tratar os erros do mais específico para o mais genérico
        {
            Console.WriteLine(ex.InnerException); //Mais usados no dia a dia
            Console.WriteLine(ex.Message); //Mais usados no dia a dia
            Console.WriteLine("Não encontrei o índice na lista!");
        }
        catch (ArgumentNullException ex)
        {
            Console.WriteLine(ex.InnerException); //Mais usados no dia a dia
            Console.WriteLine(ex.Message); //Mais usados no dia a dia
            Console.WriteLine("Falha ao cadastrar o texto!");
        }
        catch (MinhaException ex)
        {
            Console.WriteLine(ex.InnerException); //Mais usados no dia a dia
            Console.WriteLine(ex.Message); //Mais usados no dia a dia
            Console.WriteLine(ex.Mensagem);
            Console.WriteLine(ex.QuandoAconteceu);
            Console.WriteLine("Exceção customizada!");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.InnerException); //Mais usados no dia a dia
            Console.WriteLine(ex.Message); //Mais usados no dia a dia
            Console.WriteLine("Ops, algo deu errado!");
        }
        finally //Acontece sempre, mesmo se der erro
        {
            Console.WriteLine("");
            Console.WriteLine("Chegou ao fim!");
        }
    }
    public static void Cadastrar(string text)
    {
        // if (string.IsNullOrEmpty(text))
        //     throw new Exception("O texto não pode ser nulo ou vazio");

        // if (string.IsNullOrEmpty(text))
        //     throw new ArgumentNullException("O texto não pode ser nulo ou vazio");

        if (string.IsNullOrEmpty(text))
            throw new MinhaException(DateTime.Now, "O nome não pode ser vazio!");

        Console.WriteLine(text);
    }

    public class MinhaException: Exception
    {
        public MinhaException(DateTime date, string msg)
        {
            QuandoAconteceu = date;
            Mensagem = msg;
        }
        public DateTime QuandoAconteceu { get; set; }
        public string Mensagem { get; set; }
    }
}