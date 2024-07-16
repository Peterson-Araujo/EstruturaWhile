internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Digite a senha: ");
        string senha = Console.ReadLine();

        while (senha != "2002")
        {
            Console.WriteLine("Senha inválida!");
            Console.WriteLine("Digite novamente: ");
            senha = Console.ReadLine();
        }
        Console.WriteLine("Acesso permitido!");
    }
}