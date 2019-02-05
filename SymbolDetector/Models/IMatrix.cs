using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SymbolDetector.Models
{
    interface IMatrix
    {
        bool Match(int[,] src, int[,] dst);
    }
}
