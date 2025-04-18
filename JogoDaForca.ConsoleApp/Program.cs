﻿namespace JogoDaForca.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string[] palavras = {
                    "ABACATE", "ABACAXI", "ACEROLA", "ACAI", "ARACA", "ABACATE", "BACABA",
                    "BACURI", "BANANA", "CAJA", "CAJU", "CARAMBOLA", "CUPUACU", "GRAVIOLA",
                    "GOIABA", "JABUTICABA", "JENIPAPO", "MACA", "MANGABA", "MANGA", "MARACUJA",
                    "MURICI", "PEQUI", "PITANGA", "PITAYA", "SAPOTI", "TANGERINA", "UMBU", "UVA", "UVAIA"
                };

                Random random = new Random();

                int indiceEscolhido = random.Next(palavras.Length);

                string palavraEscolhida = palavras[indiceEscolhido];

                char[] letrasEncontradas = new char[palavraEscolhida.Length];

                for (int caractere = 0; caractere < letrasEncontradas.Length; caractere++)
                    letrasEncontradas[caractere] = '_';

                int quantidadeErros = 0;
                bool jogadorEnforcou = false;
                bool jogadorAcertou = false;

                do
                {
                    string cabecaDoBoneco = quantidadeErros >= 1 ? " o " : " ";
                    string tronco = quantidadeErros >= 2 ? "x" : " ";
                    string troncoBaixo = quantidadeErros >= 2 ? " x " : " ";
                    string bracoEsquerdo = quantidadeErros >= 3 ? "/" : " ";
                    string bracoDireito = quantidadeErros >= 4 ? @"\" : " ";
                    string pernas = quantidadeErros >= 5 ? "/ \\" : " ";

                    Console.Clear();
                    Console.WriteLine("----------------------------------------------");
                    Console.WriteLine("Jogo da Forca");
                    Console.WriteLine("----------------------------------------------");
                    Console.WriteLine(" ___________        ");
                    Console.WriteLine(" |/        |        ");
                    Console.WriteLine(" |        {0}       ", cabecaDoBoneco);
                    Console.WriteLine(" |        {0}{1}{2} ", bracoEsquerdo, tronco, bracoDireito);
                    Console.WriteLine(" |        {0}       ", troncoBaixo);
                    Console.WriteLine(" |        {0}       ", pernas);
                    Console.WriteLine(" |                  ");
                    Console.WriteLine(" |                  ");
                    Console.WriteLine("_|____              ");
                    Console.WriteLine("----------------------------------------------");
                    Console.WriteLine("Erros do jogador: " + quantidadeErros);
                    Console.WriteLine("----------------------------------------------");
                    Console.WriteLine("Palavra escolhida: " + String.Join("", letrasEncontradas));
                    Console.WriteLine("----------------------------------------------");

                    Console.Write("Digite uma letra: ");
                    char chute = Console.ReadLine()!.ToUpper()[0];

                    bool letraFoiEncontrada = false;

                    for (int contador = 0; contador < palavraEscolhida.Length; contador++)
                    {
                        char letraAtual = palavraEscolhida[contador];

                        if (chute == letraAtual)
                        {
                            letrasEncontradas[contador] = letraAtual;
                            letraFoiEncontrada = true;
                        }
                    }

                    if (letraFoiEncontrada == false)
                        quantidadeErros++;

                    string palavraEncontrada = String.Join("", letrasEncontradas);

                    jogadorAcertou = palavraEncontrada == palavraEscolhida;
                    jogadorEnforcou = quantidadeErros > 5;

                    if (jogadorAcertou)
                    {
                        Console.WriteLine("----------------------------------------------");
                        Console.WriteLine($"Você acertou a palavra secreta {palavraEscolhida}, parabéns!");
                        Console.WriteLine("----------------------------------------------");
                    }
                    else if (jogadorEnforcou)
                    {
                        Console.WriteLine("----------------------------------------------");
                        Console.WriteLine($"Que azar. Tente novamente! \nA palavra secreta era: {palavraEscolhida}");
                        Console.WriteLine("----------------------------------------------");
                    }

                } while (jogadorEnforcou == false && jogadorAcertou == false);

                Console.Write("Deseja continuar? (S/N): ");

                string opcaoContinuar = Console.ReadLine().ToUpper();

                if (opcaoContinuar != "S")
                    break;
            }

        }
    }
}
