
using Funcionamento_Celular;

Celular Aparelho = new Celular();



Console.WriteLine($"Informe o cor do seu aparelho celular:");
Aparelho.Cor = Console.ReadLine();

Console.WriteLine($"Informe o modelo do seu aparelho celular:");
Aparelho.Modelo = Console.ReadLine();

Console.WriteLine($"Informe o tamanho do seu aparelho celular:");
Aparelho.Tamanho = Console.ReadLine();

string opcao;

do
{
Console.Clear();
Console.WriteLine (@$"

|-----------------------------------------|
|          FUNÇÕES DO APARELHO            |
|-----------------------------------------|
|                          |              |
|         LIGAR            |     [1]      |
|         DESLIGAR         |     [2]      |
|    FAZER UMA CHAMADA     |     [3]      |
|     ENVIAR MENSAGEM      |     [4]      |
| INFORMAÇÕES DO APARELHO  |     [5]      |
|         SAIR             |     [0]      |
|-----------------------------------------|
");

Console.Write("Digite o número da função desejada: ");
opcao = Console.ReadLine();

 switch (opcao)
    {
        case "1":  
        Aparelho.Ligar();

        Console.WriteLine();
        Console.Write("Aperte <Enter> para sair... ");
        while (Console.ReadKey(true).Key != ConsoleKey.Enter) {}
        break;

         case "2":
        //  Aparelho.Desligar();
         break;
           
         case "3":
        //  Aparelho.fazerChamada();
         break;
           
         case "4":
        //  Aparelho.enviarMensagem();
         break;

         case "5":
        //  Aparelho.informacoesAparelho();
         break;

         case "6":
         Console.WriteLine("O menu de funções foi encerrado com sucesso");
         Environment.Exit(0);
         break;
    }

} while (opcao != "0");
