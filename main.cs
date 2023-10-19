using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Informe o valor do produto no exterior:");
        decimal valorProdutoExterior;

        if (!decimal.TryParse(Console.ReadLine(), out valorProdutoExterior) || valorProdutoExterior <= 0)
        {
            Console.WriteLine("Valor inválido, tente novamente mais tarde.");
            return;
        }

        Console.WriteLine("Escolha o tipo de frete (1 - Demorado, 2 - Médio, 3 - Rápido):");
        int tipoFrete;
        decimal taxaFrete = 0;

        if (!int.TryParse(Console.ReadLine(), out tipoFrete) || tipoFrete < 1 || tipoFrete > 3)
        {
            Console.WriteLine("Opção de frete inválida, tente novamente mais tarde.");
            return;
        }

        string tipoFreteEscolhido = "";

        switch (tipoFrete)
        {
            case 1:
                taxaFrete = 0.10m;
                tipoFreteEscolhido = "Frete demorado escolhido!";
                break;
            case 2:
                taxaFrete = 0.15m;
                tipoFreteEscolhido = "Frete médio escolhido!";
                break;
            case 3:
                taxaFrete = 0.20m;
                tipoFreteEscolhido = "Frete rápido escolhido!";
                break;
        }

        decimal taxaImportacao = 0.60m * valorProdutoExterior;
        decimal produtoFinal = valorProdutoExterior + taxaImportacao + (valorProdutoExterior * taxaFrete);

        Console.WriteLine($"Tipo de frete escolhido: {tipoFreteEscolhido}");
        Console.WriteLine($"Taxa de importação: {taxaImportacao:C}");
        Console.WriteLine($"Valor do frete: {valorProdutoExterior * taxaFrete:C}");
        Console.WriteLine($"Valor final da importação: {produtoFinal:C}");
    }
}
