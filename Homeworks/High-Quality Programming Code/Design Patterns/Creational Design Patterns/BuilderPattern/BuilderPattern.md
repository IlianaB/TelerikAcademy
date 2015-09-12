# Builder Pattern

  *   Motivation
      По-сложните обекти съдържат в себе си други обекти, за чието създаване се изисква допълнителна грижа от страна на програмиста. Приложението може да се нуждае от специален механизъм за изграждането на сложни обекти, които са незавизими от обектите, които ги изграждат. Builder pattern предоставя на клиента възможността да създаде сложен обект определяйки само типът и съдържанието, без да трябва да се грижи за детайлите свързани с изграждането му.
  *   Intent
      *   Дефинира инстанция за създаване на обект но оставя на подкласовете да преценят кой клас да инстанцират.
      *  Обръща се към новосъздадените обекти чрез общ интерфейс.
  *   Applicability
      Builder pattern се използва когато:
      *   Алгоритъмът за създаване на сложен обект е зависим от частите, от които е съставен обекта.
      *   Системата трябва да позволява различни начини за създаването на обекта.
  *   Known uses
      Изграждане на XML документ.
  *   Implementation
      [C# Example](https://github.com/Rostech/TelerikAcademyHomeworks/tree/master/High-Quality%20Code/18.%20Creational%20Patterns/Homework/CreationalDesignPatterns/BuilderPattern)
  *   Participants
      *   Builder - този клас представлява абстрактен интерфейс за създаване на части от Product обекта.
      *   ConcreteBuilder - конструира и свързва частите на обекта, чрез имплементирането на Builder интерфейса.
      *   Director - този клас конструира сложният обект използвайки Builder интерфейса.
      *   Product -  представя сложният обект който се изгражда.
  *   Consequences
  *   Structure
      ![alt tag](http://www.oodesign.com/images/creational/builder-pattern.png)
  *   Related patterns
      *   Simple Factory
      *   Abstract Factory
