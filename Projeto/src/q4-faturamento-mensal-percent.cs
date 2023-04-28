using System;

class Program {
    static void Main(string[] args) {
        // Faturamento mensal de uma distribuidora, detalhado por estado
        double sp = 67836.43;
        double rj = 36678.66;
        double mg = 29229.88;
        double es = 27165.48;
        double outros = 19849.53;

        // Cálculo do valor total mensal da distribuidora
        double total = sp + rj + mg + es + outros;

        // Cálculo do percentual de representação de cada estado
        double percSp = (sp / total) * 100;
        double percRj = (rj / total) * 100;
        double percMg = (mg / total) * 100;
        double percEs = (es / total) * 100;
        double percOutros = (outros / total) * 100;

        // Impressão dos resultados
        Console.WriteLine("Percentual de representação do faturamento mensal por estado:");
        Console.WriteLine("SP: {0:F2}%", percSp);
        Console.WriteLine("RJ: {0:F2}%", percRj);
        Console.WriteLine("MG: {0:F2}%", percMg);
        Console.WriteLine("ES: {0:F2}%", percEs);
        Console.WriteLine("Outros: {0:F2}%", percOutros);

        Console.ReadKey();
    }
}
