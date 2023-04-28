using System;

class Program {
    static void Main(string[] args) {
        int a = 0;
        int b = 1;
        int c = 0;
        int num = 0;
        bool encontrado = false;

        Console.Write("Digite um número inteiro: ");
        num = int.Parse(Console.ReadLine());

        while (c < num) {
            c = a + b;
            a = b;
            b = c;

            if (c == num) {
                encontrado = true;
                break;
            }
        }

        if (encontrado) {
            Console.WriteLine($"{num} pertence à sequência de Fibonacci.");
        } else {
            Console.WriteLine($"{num} não pertence à sequência de Fibonacci.");
        }
    }
}
