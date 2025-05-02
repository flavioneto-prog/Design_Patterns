using ConsoleFactoryMethod;

Console.WriteLine("FACTORY METHOD - MÉTODO FÁBRICA");

var logisticaMaritima = new LogisticaMaritima();
Console.WriteLine("EXEMPLO 1 /n");
var transporteMaritima = logisticaMaritima.CriarTransporte();
transporteMaritima.Entregar();

Console.WriteLine("EXEMPLO 2 /n");
var logisticasViaria = new LogisticaViaria();
var transporteViario = logisticasViaria.CriarTransporte();
transporteViario.Entregar();