namespace JogoDaForca.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {

                string palavraSecreta = "MELANCIA";

                char[] letrasEncontradas = new char[palavraSecreta.Length];

                for (int i = 0; i < letrasEncontradas.Length; i++)
                {
                    letrasEncontradas[i] = '_';
                }

                string dicaDaPalavra = String.Join(" ", letrasEncontradas);

                Console.Clear();
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("\tJogo da Forca");
                Console.WriteLine("---------------------------------------");
                Console.WriteLine($"Palavra secreta: {dicaDaPalavra}");
                Console.WriteLine("---------------------------------------");
            }

            Console.Write("Digite uma letra: ");
            char chute = Console.ReadLine()[0];

            Console.WriteLine(chute);

            Console.ReadLine();
        }
    }
}
