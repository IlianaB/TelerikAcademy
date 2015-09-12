# Factory Method Pattern

  *   Motivation
      Factory Method предоставя интерфейс за създаване на обект, но оставя изборът на тип на подкласовете, като създаването е отложено на ниво run-time.
  *   Intent
      *   Дефинира интерфейс за създаване на обекти, оставяйки подкласовете да избират кой клас да инстанцират.
      *   Достъпва новия обект чрез общ интерфейс.
      *   Добавянето на нови Factories и Classes става без нарушаването на Open/Close принципа.
  *   Applicability
      *   Когато класът не може да предвиди типът на обекта който трябва да създаде.
      *   Когато класът желае неговите подкласове да бъдат тези, който определят типа на новосъздадения обект.
  *   Known uses
      Този метод позволява на клиента да създава нов обекти без да трябва да знае детайлите относно начина, по който се създават или какви зависимости притежават.
  *   Implementation
      [C# Example](https://github.com/Rostech/TelerikAcademyHomeworks/tree/master/High-Quality%20Code/18.%20Creational%20Patterns/Homework/CreationalDesignPatterns/FactoryMethod)
  *   Participants
      *   Product - дефинира интерфейсът за обектите които factoryMethod създава.
      *   ConcreteProduct - имплементира интерфейсът на Product.
      *   Factory (creator) - декларира методът FactoryMethod, който връща обект от тип Product.
      *   ConcreteCreator - override-ва методът за създаване на обект от тип ConcreteProduct.
  *   Consequences
  *   Structure
      ![alt tag](http://www.oodesign.com/images/stories/factory%20method%20implementation%20-%20uml%20class%20diagram.gif)
  *   Related patterns
      *   Simple Factory
      *   Abstract Factory
