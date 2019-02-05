using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using SymbolDetector.Models;

namespace SymbolDetector.Implementation
{
    class Matrix : IMatrix
    {
        public bool Match(int[,] src, int[,] dst)
        {
            var equal =
                src.Rank == dst.Rank &&
                Enumerable.Range(0, src.Rank).All(dimension => src.GetLength(dimension) == dst.GetLength(dimension)) &&
                src.Cast<int>().SequenceEqual(dst.Cast<int>());

            return equal;
        }
    }
}
