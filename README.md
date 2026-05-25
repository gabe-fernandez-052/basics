# Design Patterns

C# implementations of all 23 Gang of Four design patterns from *Design Patterns* by Gamma, Helm, Johnson, and Vlissides. Each pattern uses the book's own example scenario and includes a `Client` class with a *What is it?* / *When to use?* summary.

Run all patterns:

```bash
dotnet run
```

## Patterns

### Creational

| Pattern | Book scenario |
|---------|--------------|
| Abstract Factory | UI widget families (Windows vs macOS buttons and scrollbars) |
| Builder | Maze construction with rooms and doors |
| Factory Method | Document pages created by application subclasses |
| Prototype | Cloning graphic shapes |
| Singleton | Single shared instance |

### Structural

| Pattern | Book scenario |
|---------|--------------|
| Adapter | TextView adapted to fit the Shape interface |
| Bridge | Window rendering across platforms (Windows / Linux) |
| Composite | Recursive picture made of lines, circles, and nested pictures |
| Decorator | Beverage cost calculation with condiment add-ons |
| Facade | Home theater system (amplifier, projector, DVD player) |
| Flyweight | Character rendering with shared font/size intrinsic state |
| Proxy | Virtual image proxy with lazy loading |

### Behavioral

| Pattern | Book scenario |
|---------|--------------|
| Chain of Responsibility | Help system — Button → Dialog → Application |
| Command | Open and Paste document commands via menu items |
| Interpreter | Boolean variable expressions (AND, OR, NOT) |
| Iterator | Sequential traversal of a custom number collection |
| Mediator | Font dialog — ListBox selection synced to EntryField |
| Memento | Graphic editor move with undo via saved snapshots |
| Observer | ClockTimer driving DigitalClock and AnalogClock displays |
| State | TCP connection lifecycle (Closed → Listen → Established) |
| Strategy | Payment methods (credit card, PayPal, cryptocurrency) |
| Template Method | Application/Document framework with pluggable open steps |
| Visitor | Abstract syntax tree with type-checking and code-generation passes |

## Stack

- .NET 10 / C#
