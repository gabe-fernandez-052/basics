using DesignPatterns.Structural.Bridge.ConcreteImplementor;
using DesignPatterns.Structural.Bridge.Implementor;
using DesignPatterns.Structural.Bridge.RefinedAbstraction;

namespace DesignPatterns.Structural.Bridge
{
    /// <summary>
    /// When to use?
    /// You want to avoid a permanent binding, between an abstraction and its implementation. 
    /// This might be the case, for example, when the implementation must be selected or switched at run time.
    /// Both the abstractions and their implementations should be extensible by subclassing. In this case, the Bridge pattern lets you combine the different abstractions
    /// and implmentations and extend them independently.
    /// Changes in the implmentation of an abstraction should have no impact on clients; that is, their code should not have to be recompiled. 
    /// </summary>
    public class Client
    {
        public void Run()
        {
            IWindowRenderer windowsRenderer = new WindowsRenderer();
            IWindowRenderer linuxRenderer = new LinuxRenderer();

            var dialogWindow = new DialogWindow(windowsRenderer);
            dialogWindow.Draw();

            var iconWindow = new IconWindow(linuxRenderer);
            iconWindow.Draw();
        }
    }
}
