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

## 🧠 Características Chave dos Padrões Comportamentais
```
Padrão	                | Intenção
------------------------------------------------------------------------------------------------------------------
Strategy                | Encapsular algoritmos ou comportamentos intercambiáveis
------------------------------------------------------------------------------------------------------------------
Observer                | Notificar objetos sobre mudanças de estado
------------------------------------------------------------------------------------------------------------------
Command	                | Encapsular uma solicitação como um objeto
------------------------------------------------------------------------------------------------------------------
Chain of Responsibility | Passar solicitações por uma cadeia de manipuladores
------------------------------------------------------------------------------------------------------------------
Mediator	              | Centralizar a comunicação complexa entre objetos
------------------------------------------------------------------------------------------------------------------
State	                  | Permitir que o comportamento do objeto mude com seu estado interno
------------------------------------------------------------------------------------------------------------------
Template Method         | Definir o esqueleto de um algoritmo em um método
------------------------------------------------------------------------------------------------------------------
Visitor	                | Executar operações em elementos de uma estrutura sem alterá-los
------------------------------------------------------------------------------------------------------------------
Iterator	              | Acessar elementos de um agregado sequencialmente sem expor seus componentes internos
------------------------------------------------------------------------------------------------------------------
Memento	                | Capturar e restaurar o estado interno de um objeto
------------------------------------------------------------------------------------------------------------------
Interpreter	            | Definir uma gramática e interpretar frases no idioma
------------------------------------------------------------------------------------------------------------------
```
