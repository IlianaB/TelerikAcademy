# Abstract Factory Pattern

  *   Motivation
      В програмирането е добре да се избягва идеята за добавяне на код към вече съществуващи класове за да могат да енкапсулират по обща информация. Избягването на това усложняване става чрез Abstract Factory моделът.
  *   Intent
      Abstract Factory шаблонът предоставя интерфейс за създаване на група от свързани обекти, без изрично да се посочва техният  клас.
  *   Applicability
      Използвайте Abstract Factory когато:
      *   Системата трябва да бъде независима от начина, по който обектите с които работи са създадени.
      *   Системата е или трябва да бъде конфигурирана да работи с множество "семейства" от обекти.
      *   Група обекти е конструирана да работи изцяло заедно.
      *   Създаването на библиотека от обекти е необходимо, и към нея се отнася само интерфейса, а не имплементацията.
  *   Known uses
  *   Implementation
      [C# Example](https://github.com/Rostech/TelerikAcademyHomeworks/tree/master/High-Quality%20Code/18.%20Creational%20Patterns/Homework/CreationalDesignPatterns/AbstractFactory)
  *   Participants
      *   AbstractFactory - декларира интерфейс за методи които създават абстрактни продукти.
      *   ConcreteFactory - имплементира методите за създаване на конкретни продукти.
      *   AbstractProduct - декларира интерфейс за даден тип обекти.
      *   Product - дефинира продукта за инициализиране съответстващ на ConcreteFactory и имплементира интерфейсът AbstractProduct.
      *   Client - използва интерфейса деклариран от AbstractFactory и AbstractProduct класовете.
  *   Consequences
  *   Structure
      ![alt tag](http://www.oodesign.com/images/creational/abstract-factory-pattern.png)
  *   Related patterns
      *   Factory Method
      *   Builder
