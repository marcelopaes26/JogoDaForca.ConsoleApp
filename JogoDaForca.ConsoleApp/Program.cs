namespace JogoDaForca.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                string palavraSecreta = "UVA";

                char[] letrasEncontradas = new char[palavraSecreta.Length];

                for (int i = 0; i < letrasEncontradas.Length; i++)
                {
                    letrasEncontradas[i] = '_';
                }

                int quantidadeErros = 0;
                bool jogadorEnforcou = false, jogadorAcertou = false;

                do
                {

                    string dicaDaPalavra = String.Join(" ", letrasEncontradas);

                    Console.Clear();
                    Console.WriteLine("---------------------------------------");
                    Console.WriteLine("\tJogo da Forca");
                    Console.WriteLine("---------------------------------------");
                    Console.WriteLine($"Palavra secreta: {dicaDaPalavra}");
                    Console.WriteLine("---------------------------------------");
                    Console.WriteLine($"Quantidade de erros: {quantidadeErros}");
                    Console.WriteLine("---------------------------------------");

                    Console.Write("Digite uma letra: ");
                    char chute = Console.ReadLine()[0];

                    bool letraFoiEncontrada = false;

                    for (int i = 0; i < palavraSecreta.Length; i++)
                    {
                        char letraAtual = palavraSecreta[i];

                        if (chute == letraAtual)
                        {
                            letrasEncontradas[i] = letraAtual;
                            letraFoiEncontrada = true;
                        }

                    }

                    if (!letraFoiEncontrada)
                    {
                        quantidadeErros++;
                    }

                    dicaDaPalavra = String.Join("", letrasEncontradas);

                    jogadorAcertou = dicaDaPalavra == palavraSecreta;
                    jogadorEnforcou = quantidadeErros > 5;

                    if (jogadorAcertou)
                    {
                        Console.WriteLine("---------------------------------------");
                        Console.WriteLine("Você acertou a palavra secreta!");
                        Console.WriteLine("---------------------------------------");
                    }
                    else if (jogadorEnforcou)
                    {
                        Console.WriteLine("---------------------------------------");
                        Console.WriteLine($"Que azar, tente novamente! \nA palavra era: {palavraSecreta}");
                        Console.WriteLine("---------------------------------------");
                    }

                    Console.ReadLine();

                } while (jogadorAcertou == false && jogadorEnforcou == false);

            }

        }
    }
}
