using AbstractFactory.Domain.Enums;
using AbstractFactoryDemo.Domain.Enums;
using AbstractFactoryDemo.Domain.Products;
using AbstractFactoryDemo.Factory.AbstractFactory;

// Obtém as fábricas
var boloFactory = MassasAbstractFactory.CriarFabricaMassas(ETipoMassa.Bolo);
var pizzaFactory = MassasAbstractFactory.CriarFabricaMassas(ETipoMassa.Pizza);

// Cria os objetos com base no tipo bolo
var bolo1 = boloFactory.CriarMassa((ETipoMassa)ETipoBolo.Chocolate);
var bolo2 = boloFactory.CriarMassa((ETipoMassa)ETipoBolo.Laranja);

// Cria os objetos com base no tipo pizza
var pizza1 = pizzaFactory.CriarMassa((ETipoMassa)ETipoPizza.Mussarela);
var pizza2 = pizzaFactory.CriarMassa((ETipoMassa)ETipoPizza.Calabreza);

// Exibe os detalhes
ExibirDetalhes(bolo1);
ExibirDetalhes(bolo2);
ExibirDetalhes(pizza1);
ExibirDetalhes(pizza2);

Console.ReadLine();

static void ExibirDetalhes(MassaBase massaBase)
{
    Console.WriteLine($"Tipo: {massaBase.TipoMassa}");
    Console.WriteLine(massaBase.Nome);
    Console.WriteLine(massaBase.Ingredientes[0].ToString());
    Console.WriteLine("\n");
}