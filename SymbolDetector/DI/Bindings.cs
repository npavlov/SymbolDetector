using Ninject.Modules;
using Ninject;
using SymbolDetector.Implementation;
using SymbolDetector.Models;

public class Bindings : NinjectModule
{
    public override void Load()
    {
        Bind<IReader>().To<Reader>();

        Bind<ISymbolFinder>().To<SymbolFinder>();

        Bind<INormilizer>().To<Normilizer>();

        Bind<IMatrix>().To<Matrix>();

        Bind<IBorder>().To<Border>();

        Bind<ISymbol>().To<One>();

        Bind<ISymbol>().To<Two>();

        Bind<ISymbol>().To<Three>();

        Bind<ISymbol>().To<Four>();

        Bind<ISymbol>().To<Five>();
    }
}