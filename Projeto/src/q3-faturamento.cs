using System;
using System.IO;
using Newtonsoft.Json;

class Program {
    static void Main(string[] args) {
        // Lê o arquivo JSON com os valores de faturamento diário
        string json = File.ReadAllText("faturamento.json");
        Faturamento[] faturamento = JsonConvert.DeserializeObject<Faturamento[]>(json);

        // Calcula o menor valor de faturamento diário
        double menor = double.MaxValue;
        foreach (Faturamento f in faturamento) {
            if (f.Valor < menor) {
                menor = f.Valor;
            }
        }
        Console.WriteLine($"Menor valor de faturamento diário: {menor}");

        // Calcula o maior valor de faturamento diário
        double maior = double.MinValue;
        foreach (Faturamento f in faturamento) {
            if (f.Valor > maior) {
                maior = f.Valor;
            }
        }
        Console.WriteLine($"Maior valor de faturamento diário: {maior}");

        // Calcula a média mensal de faturamento diário
        double soma = 0;
        int cont = 0;
        foreach (Faturamento f in faturamento) {
            if (f.Data.DayOfWeek != DayOfWeek.Saturday && f.Data.DayOfWeek != DayOfWeek.Sunday) {
                soma += f.Valor;
                cont++;
            }
        }
        double media = soma / cont;

        // Conta o número de dias em que o valor de faturamento diário foi superior à média mensal
        int acimaDaMedia = 0;
        foreach (Faturamento f in faturamento) {
            if (f.Valor > media && f.Data.DayOfWeek != DayOfWeek.Saturday && f.Data.DayOfWeek != DayOfWeek.Sunday) {
                acimaDaMedia++;
            }
        }
        Console.WriteLine($"Número de dias com faturamento acima da média mensal: {acimaDaMedia}");
    }
}

class Faturamento {
    public DateTime Data { get; set; }
    public double Valor { get; set; }
}
