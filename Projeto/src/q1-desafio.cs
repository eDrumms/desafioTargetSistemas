internal partial class Program
{
    private static void Main(string[] args)
    {
        var INDICE = 13;
        int SOMA = 0;
        int K = 0;

        while (K < INDICE)   //o código realiza um laço de repetição que soma os números inteiros de 1 até o valor da variável ÍNDICE (que é 13).
        {                   //o processo continua enquanto a variável K for menor que o valor da variável Índice.
            K = K + 1;    //K é a variável acumuladora
            SOMA = SOMA + K;
        }

        Console.WriteLine(SOMA);   //o valor da variável SOMA é 91
    }
}