using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SymbolDetector.Models
{
    interface IBorder
    {
        bool MatchBorders(int x, int y, int[,] data, int xLength, int symbolXDem, int symbolYDem);
    }
}
