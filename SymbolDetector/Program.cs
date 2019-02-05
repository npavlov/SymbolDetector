using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using SymbolDetector.Implementation;
using SymbolDetector.Models;

namespace SymbolDetector
{
    class Program
    {
        static void Main(string[] args)
        {
            var kernel = new StandardKernel();
            kernel.Load(Assembly.GetExecutingAssembly());
            var reader = kernel.Get<IReader>();

            var data = reader.GetData("NumberParserExtended.txt");

            var symbols = kernel.GetAll<ISymbol>();

            var comparer = kernel.Get<SymbolFinder>();

            foreach (var symbol in symbols)
            {
                var results = comparer.FindPatterns(symbol, data);

                foreach (var result in results)
                {
                    Console.WriteLine(result);
                }
            }
            

            Console.ReadLine();
        }
    }
}
