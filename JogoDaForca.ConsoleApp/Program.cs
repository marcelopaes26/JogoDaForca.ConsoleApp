namespace JogoDaForca.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.Clear();
                Console.WriteLine("----------------------------");
                Console.WriteLine("\tJogo da Forca");
                Console.WriteLine("----------------------------");
            }

            Console.Write("Digite uma palavra: ");
            char chute = Console.ReadLine()[0];
        }
    }
}
