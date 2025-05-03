using Builder.ConcreteBuilder;
using Builder.Director;

// Director
var pizzaria = new Pizzaria(new PizzaCalabreza());
pizzaria.MontarPizza();
var pizza1 = pizzaria.ObterPizza();
pizza1.EscreverConteudo();

pizzaria = new Pizzaria(new PizzaMussarela());
pizzaria.MontarPizza();
var pizza2 = pizzaria.ObterPizza();
pizza2.EscreverConteudo();