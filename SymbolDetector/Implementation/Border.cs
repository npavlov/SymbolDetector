using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SymbolDetector.Models;

namespace SymbolDetector.Implementation
{
    class Border : IBorder
    {
        public bool MatchBorders(int x, int y, int[,] data, int xLength, int symbolXDem, int symbolYDem)
        {
            bool spaceBorder = true;
            if (x == 0)
            {

                for (int y1 = 0; y1 < symbolYDem; y1++)
                {
                    if (data[y + y1, x + symbolXDem] != ' ')
                    {
                        spaceBorder = false;
                    }
                }
            }
            else if (x + symbolXDem == xLength)
            {

                for (int y1 = 0; y1 < symbolYDem; y1++)
                {
                    if (data[y + y1, x - 1] != ' ')
                    {
                        spaceBorder = false;
                    }
                }
            }
            else
            {
                for (int y1 = 0; y1 < symbolYDem; y1++)
                {
                    if (data[y + y1, x - 1] != ' ')
                    {
                        spaceBorder = false;
                    }
                    if (data[y + y1, x + symbolXDem] != ' ')
                    {
                        spaceBorder = false;
                    }
                }
            }

            return spaceBorder;
        }

    }
}
