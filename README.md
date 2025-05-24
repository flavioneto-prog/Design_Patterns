# Design Patterns

Este repositório contém um estudo prático sobre os principais padrões de projeto (design patterns) aplicados em C#. 
O objetivo é demonstrar como implementar e utilizar esses padrões para melhorar a estrutura, flexibilidade e manutenção de sistemas orientados a objetos.

## 📚 Sobre o Projeto

O projeto é uma coleção de implementações de padrões de projeto clássicos, divididos em três categorias principais:

* Padrões Criacionais: Envolvem processos de criação de objetos, visando aumentar a flexibilidade e a reutilização de código.

* Padrões Estruturais: Tratam da composição de classes e objetos para formar estruturas maiores e mais complexas.

* Padrões Comportamentais: Focam na comunicação entre objetos e na delegação de responsabilidades.

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
| Singleton               | Garantir que uma classe tenha apenas uma instância e fornecer um ponto de acesso global.
| Factory Method          | Definir uma interface para criar um objeto, mas permite que as subclasses alterem o tipo.
| Abstract Factory        | Fornecer uma interface para criar famílias de objetos relacionados ou dependentes.
| Builder                 | Separar a construção de um objeto complexo de sua representação.
| Prototype               | Criar novos objetos copiando um objeto existente.

## 🧠 Características Chave dos Padrões Estruturais

| Padrão                  | Intenção                                                                             |
| ----------------------- |:------------------------------------------------------------------------------------:|
| Adapter                 | Converter uma interface em outra que um cliente espera.
| Bridge                  | Desacoplar uma abstração de sua implementação para que elas possam variar independentemente.
| Composite               | Compor objetos em estruturas de árvore para representar hierarquias parte-todo.
| Decorator               | Permite adicionar dinamicamente funcionalidade e comportamento a um objeto sem afetar o comportamento de outros objetos existentes na mesma classe.
| Facade                  | Fornecer uma interface simplificada para um subsistema complexo.
| Flyweight               | Reduzir o uso de memória ao compartilhar partes comuns do estado entre vários objetos.
| Proxy                   | Fornecer um substituto ou espaço reservado para controlar o acesso a outro objeto.

## 🧠 Características Chave dos Padrões Comportamentais

| Padrão                  | Intenção                                                                             |
| ----------------------- |:------------------------------------------------------------------------------------:|
| Strategy                | Encapsular algoritmos ou comportamentos intercambiáveis.
| Observer                | Notificar objetos sobre mudanças de estado.
| Command                 | Transforma uma solicitação em um objeto independente, contendo todas as informações sobre a solicitação.
| Chain of Responsibility | Passar solicitações por uma cadeia de manipuladores/objetos.
| Mediator                | Centralizar a comunicação complexa entre objetos.
| State                   | Permitir que o comportamento do objeto mude com seu estado interno.
| Template Method         | Definir um algoritmo como um esqueleto de operações e deixar os detalhes para serem implementados pelas classes filhas.
| Visitor                 | Permite separar algoritmos dos objetos nos quais operam. Ele permite adicionar novas operações a estruturas de objetos existentes sem modificá-las.
| Iterator                | Acessar elementos de um agregado sequencialmente sem expor seus componentes internos.
| Memento                 | Capturar e restaurar o estado interno de um objeto.
| Interpreter             | Definir uma representação gramatical para uma linguagem e fornece um intérprete para lidar com essa gramática.

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
