namespace Builder.Product;

public class Pizza
{
    public ETipoMassa TipoMassa { get; set; }

    public ETipoBorda TipoBorda { get; set; }

    public ETamanho Tamanho { get; set; }

    public List<string> Ingredientes { get; set; } = default!;

    public void EscreverConteudo()
    {
        Console.WriteLine($"Pizza com a massa: {TipoMassa}");
        Console.WriteLine($"Tipo de borda: {TipoBorda}");
        Console.WriteLine($"Tamanho: {Tamanho}");
        Console.WriteLine($"Ingredientes: ");

        foreach (var ingrediente in Ingredientes)
        {
            Console.WriteLine($"{ingrediente}");
        }

        Console.WriteLine("\n\n");
    }
}