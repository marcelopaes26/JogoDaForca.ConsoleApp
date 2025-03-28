# Jogo da Forca

Bem-vindo ao **Jogo da Forca**, um jogo clássico implementado em C# no formato de aplicativo de console. Neste jogo, o jogador tenta adivinhar uma palavra secreta, letra por letra, antes que o boneco seja completamente "enforcado". As palavras são frutas típicas, o que adiciona um toque educativo e divertido!

## Como Jogar
1. Ao iniciar o jogo, uma palavra secreta (uma fruta) é escolhida aleatoriamente.
2. A palavra é exibida como uma sequência de underscores (`_`), representando cada letra a ser adivinhada.
3. Digite uma letra para fazer um chute:
   - Se a letra estiver na palavra, ela será revelada nas posições corretas.
   - Se a letra não estiver na palavra, o boneco da forca ganhará uma parte (cabeça, tronco, braços ou pernas).
4. Você tem até **6 erros** antes de perder o jogo.
5. Continue chutando letras até:
   - Adivinhar a palavra completa (vitória) ou
   - O boneco ser enforcado (derrota).
6. Ao final de cada partida, você pode escolher continuar (`S`) ou encerrar o jogo (`N`).


## Requisitos
- .NET Framework ou .NET Core instalado para compilar e executar o código.

## Como Executar
1. Clone este repositório ou copie o código para um arquivo `.cs`.
2. Abra o terminal no diretório do projeto.
3. Compile e execute o programa com os comandos:

    ```bash
    dotnet build
    dotnet run

4. Divirta-se jogando!

## Tecnologias Usadas
![C#](https://skillicons.dev/icons?i=cs) ![.NET](https://skillicons.dev/icons?i=dotnet,git,github,vscode)