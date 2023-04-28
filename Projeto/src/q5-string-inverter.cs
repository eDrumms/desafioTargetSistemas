using System;

class Program {
    static void Main(string[] args) {
        // Definindo a string a ser invertida
        string str = "Exemplo de string";

        // Criando um array de caracteres a partir da string
        char[] charArray = str.ToCharArray();

        // Obtendo o comprimento da string
        int length = charArray.Length;

        // Iterando sobre o array de caracteres até o meio da string
        for (int i = 0; i < length / 2; i++) {
            // Trocando o caractere na posição i com o caractere na posição length - i - 1
            char temp = charArray[i];
            charArray[i] = charArray[length - i - 1];
            charArray[length - i - 1] = temp;
        }

        // Convertendo o array de caracteres de volta para a string
        string reversedStr = new string(charArray);

        // Imprimindo a string invertida
        Console.WriteLine(reversedStr);
    }
}
