static void Run(string name, Action action)
{
    Console.WriteLine($"{'=',0}".PadRight(60, '='));
    Console.WriteLine($"  {name}");
    Console.WriteLine($"{'=',0}".PadRight(60, '='));
    action();
    Console.WriteLine();
}

// ── Creational ────────────────────────────────────────────────
Run("Abstract Factory", () => new DesignPatterns.Creational.AbstractFactory.Client().Run());
Run("Builder",          () => new DesignPatterns.Creational.Builder.Client().Run());
Run("Factory Method",   () => new DesignPatterns.Creational.FactoryMethod.Client().Run());
Run("Prototype",        () => new DesignPatterns.Creational.Prototype.Client().Run());
Run("Singleton",        () => new DesignPatterns.Creational.Singleton.Client().Run());

// ── Structural ────────────────────────────────────────────────
Run("Adapter",          () => new DesignPatterns.Structural.Adapter.Client().Run());
Run("Bridge",           () => new DesignPatterns.Structural.Bridge.Client().Run());
Run("Composite",        () => new DesignPatterns.Structural.Composite.Client().Run());
Run("Decorator",        () => new DesignPatterns.Structural.Decorator.Client().Run());
Run("Facade",           () => new DesignPatterns.Structural.Facade.Client().Run());
Run("Flyweight",        () => new DesignPatterns.Structural.Flyweight.Client().Run());
Run("Proxy",            () => new DesignPatterns.Structural.Proxy.Client().Run());

// ── Behavioral ────────────────────────────────────────────────
Run("Chain of Responsibility", () => new DesignPatterns.Behavioral.ChainOfResponsibility.Client().Run());
Run("Command",                 () => new DesignPatterns.Behavioral.Command.Client().Run());
Run("Interpreter",             () => new DesignPatterns.Behavioral.Interpreter.Client().Run());
Run("Iterator",                () => new DesignPatterns.Behavioral.Iterator.Client().Run());
Run("Mediator",                () => new DesignPatterns.Behavioral.Mediator.Client().Run());
Run("Memento",                 () => new DesignPatterns.Behavioral.Memento.Client().Run());
Run("Observer",                () => new DesignPatterns.Behavioral.Observer.Client().Run());
Run("State",                   () => new DesignPatterns.Behavioral.State.Client().Run());
Run("Strategy",                () => new DesignPatterns.Behavioral.Strategy.Client().Run());
Run("Template Method",         () => new DesignPatterns.Behavioral.TemplateMethod.Client().Run());
Run("Visitor",                 () => new DesignPatterns.Behavioral.Visitor.Client().Run());
