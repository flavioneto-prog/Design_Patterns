using ConsoleBridge;

Cliente client = new();

Abstracao abstracao;
abstracao = new Abstracao(new ImplementacaoConcretaA());
client.CodigoCliente(abstracao);

Console.WriteLine();

abstracao = new AbstracaoEstendida(new ImplementacaoConcretaB());
client.CodigoCliente(abstracao);