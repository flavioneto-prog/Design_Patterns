# Design Patterns

Este repositório contém um estudo prático sobre os principais padrões de projeto (design patterns) aplicados em C#. 
O objetivo é demonstrar como implementar e utilizar esses padrões para melhorar a estrutura, flexibilidade e manutenção de sistemas orientados a objetos.

## 📚 Sobre o Projeto

O projeto é uma coleção de implementações de padrões de projeto clássicos, divididos em três categorias principais:

1. Padrões Criacionais

2. Padrões Estruturais

3. Padrões Comportamentais

## 🔧 Tecnologias Utilizadas

* C#

* .NET Core

## 🧪 Estrutura do Repositório

```
Design_Patterns/
├── CreationalPatterns/
├── StructuralPatterns/
├── BehavioralPatterns/
└── OthersPatterns/
```

* CreationalPatterns: Contém implementações de padrões como Singleton, Factory Method, Abstract Factory, Builder.

* StructuralPatterns: Inclui padrões como Bridge.

* BehavioralPatterns: Abrange padrões como State, Strategy, Template Method.

* OthersPatterns: Apresenta padrões adicionais, como Null Object.

## 🚀 Como Executar

1. Clone este repositório em sua máquina local:

```
git clone https://github.com/flavioneto-prog/Design_Patterns.git
```

2. Abra o arquivo DesignPatterns.sln no Visual Studio ou utilize o .NET CLI:
```
dotnet run
```

## 📌 Padrões Criacionais
* Os padrões de design criacionais ajudam a tornar um sistema independente de como seus objetos são criados, compostos e representados.

## 📌 Padrões Estruturais
* Os padrões de design estruturais se preocupam com a forma como as classes e os objetos são compostos para formar uma grande estrutura.

## 📌 Padrões Comportamentais
* Os padrões de design comportamentais estão relacionados a algoritmos e à atribuição de responsabilidades entre objetos.

## 🧠 Características Chave dos Padrões Criacionais

| Padrão                  | Intenção                                                                             |
| ----------------------- |:------------------------------------------------------------------------------------:|
| Singleton               | Garante que uma classe tenha apenas uma instância e fornece um ponto global de acesso a ela.
| Factory Method          | Define uma interface para criar um objeto, mas permite que subclasses decidam qual classe instanciar.
| Abstract Factory        | Fornece uma interface para criar famílias de objetos relacionados ou dependentes, sem especificar suas classes concretas.
| Builder                 | Separa a construção de um objeto complexo da sua representação, permitindo diferentes representações com o mesmo processo de construção.
| Prototype               | Cria novos objetos copiando uma instância existente (clone), em vez de criar a partir do zero.

## 🧠 Características Chave dos Padrões Estruturais

| Padrão                  | Intenção                                                                             |
| ----------------------- |:------------------------------------------------------------------------------------:|
| Adapter                 | Permite que interfaces incompatíveis trabalhem juntas, convertendo a interface de uma classe em outra esperada.
| Bridge                  | Separa uma abstração da sua implementação, permitindo que as duas evoluam independentemente.
| Composite               | Compõe objetos em estruturas de árvore para representar hierarquias "parte-todo". Permite tratar objetos individuais e composições de maneira uniforme.
| Decorator               | Adiciona responsabilidades a objetos dinamicamente, como alternativa flexível à subclasse.
| Facade                  | Fornece uma interface unificada para um conjunto de interfaces em um subsistema, tornando-o mais fácil de usar.
| Flyweight               | Usa compartilhamento para suportar grandes quantidades de objetos de forma eficiente, quando muitos objetos têm o mesmo estado interno.
| Proxy                   | Fornece um substituto ou representante de outro objeto para controlar o acesso a ele (ex: cache).

## 🧠 Características Chave dos Padrões Comportamentais

| Padrão                  | Intenção                                                                             |
| ----------------------- |:------------------------------------------------------------------------------------:|
| Strategy                | Define uma família de algoritmos, encapsula cada um e os torna intercambiáveis.
| Observer                | Define uma dependência um-para-muitos entre objetos, de modo que quando um objeto muda de estado, seus dependentes são notificados automaticamente.
| Command                 | Encapsula uma solicitação como um objeto, permitindo parametrizar clientes com diferentes requisições, enfileirar ou fazer log de comandos.
| Chain of Responsibility | Passa uma solicitação por uma cadeia de objetos até que um deles a trate.
| Mediator                | Define um objeto que encapsula como um conjunto de objetos interage, promovendo o baixo acoplamento.
| State                   | Permite a um objeto alterar seu comportamento quando seu estado interno muda, como se ele mudasse de classe.
| Template Method         | Define o esqueleto de um algoritmo numa operação, deixando alguns passos para subclasses.
| Visitor                 | Permite definir novas operações em uma estrutura de objetos sem modificar as classes dos elementos em que opera.
| Iterator                | Fornece uma maneira de acessar elementos de uma coleção sequencialmente, sem expor sua estrutura interna.
| Memento                 | Captura e externaliza o estado interno de um objeto sem violar o encapsulamento, permitindo restaurar esse estado depois.
| Interpreter             | Interpreta sentenças de uma linguagem definida por uma gramática.

## 💡 Casos de Uso
1. Melhorando a escalabilidade:
   1. Nos permite criar recursos flexíveis e mais fáceis de adicionar novos.
2. Simplificando problemas complexos:
   1. Problema resolvido, torna o código mais sustentável.
3. Melhorando a colaboração:
   1. Facilidade de colaborar nos projetos.
4. Melhorando a testabilidade:
   1. Software mais fácil de testar, mais confiável e robusto.
5. Promovendo a reutilização do código:
   1. Criar modelos reutilizáveis.
6. Melhorando a capacidade de manutenção:
   1. Organização do código, facilidade de manter e de atualizar.

## 💻 Referências de Artigos
1. https://refactoring.guru/design-patterns/catalog
2. https://www.geeksforgeeks.org/complete-guide-to-design-patterns-in-programming/?utm_source=chatgpt.com
3. https://www.macoratti.net/vb_pd1.htm
4. https://medium.com/design-bootcamp/a-comprehensive-guide-to-design-patterns-ca80837c7de9

## 📚 Referência de Livro
1. Design Patterns com Java (Casa do Código)
