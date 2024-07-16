internal class Program
{
    private static void Main(string[] args)
    {
        int alcool = 0;
        int gasolina = 0;
        int diesel = 0;
        int combustivel;

        Console.WriteLine("Digite o tipo de combustível que deseja abastecer (1. Álcool, 2.Gasolina ou 3.Diesel): ");
        combustivel = int.Parse(Console.ReadLine());        

        while (combustivel != 4) {
            switch (combustivel)
            {
                case 1:
                    Console.WriteLine("Álcool");
                    alcool++;
                    break;
                case 2:
                    Console.WriteLine("Gasolina");
                    gasolina++;
                    break;
                case 3:
                    Console.WriteLine("Diesel");
                    diesel++;
                    break;
            }

            if (combustivel >= 4) {
                Console.WriteLine("Digite um código válido!");
            }

            Console.WriteLine("Digite o tipo de combustível que deseja abastecer (1. Álcool, 2.Gasolina ou 3.Diesel): ");
            combustivel = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Muito obrigado!");
        Console.WriteLine("Alcool: " + alcool);
        Console.WriteLine("Gasolina: " + gasolina);
        Console.WriteLine("Diesel: " + diesel);
    }
}