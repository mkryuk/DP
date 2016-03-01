using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DP.Behavioral.Chain_of_responsibility;
using DP.Behavioral.Command;
using DP.Behavioral.Interpreter;
using DP.Behavioral.Iterator;
using DP.Behavioral.Mediator;
using DP.Behavioral.Memento;
using DP.Creational.AbstractFactory;
using DP.Creational.Builder;
using DP.Creational.FactoryMethod;
using DP.Creational.Prototype;
using DP.Creational.Singleton;
using DP.Structural.Adapter;
using DP.Structural.Bridge;
using DP.Structural.Composite;
using DP.Structural.Decorator;
using DP.Structural.Facade;
using DP.Structural.Flyweight;
using DP.Structural.Proxy;

namespace DP
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creational patterns//
            //UsingAbstractFactory.Run();
            //UsingBuilder.Run();
            //UsingFactoryMethod.Run();
            //UsingPrototype.Run();
            //UsingSingleton.Run();
            
            //Structural patterns//
            //UsingAdapter.Run();
            //UsingBridge.Run();
            //UsingComposite.Run();
            //UsingDecorator.Run();
            //UsingFacade.Run();
            //UsingFlyweight.Run();
            //UsingProxy.Run();

            //Behavioral patterns//
            //UsingChainOfResponsibility.Run();
            //UsingCommand.Run();
            //UsingInterpreter.Run();
            //UsingIterator.Run();
            //UsingMediator.Run();
            UsingMemento.Run();
        }
    }
}
