using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SymbolDetector.Models;

namespace SymbolDetector.Implementation
{
    class One : ISymbol
    {
        public int[,] GetSymbol =>
            new int[,]
            {
                {'|'},
                {'|'},
                {'|'},
                {'|'}
            };
        public override string ToString()
        {
            return "1";
        }
    }

    class Two : ISymbol
    {
        public int[,] GetSymbol =>
            new int[,]
            {
                {'-','-','-'},
                {' ','_','|'},
                {'|',' ',' '},
                {'-','-','-'}
            };
        public override string ToString()
        {
            return "2";
        }
    }

    class Three : ISymbol
    {
        public int[,] GetSymbol =>
            new int[,]
            {
                {'-','-','-'},
                {' ','/',' '},
                {' ','\\',' '},
                {'-','-',' '}
            };
        public override string ToString()
        {
            return "3";
        }
    }

    class Four : ISymbol
    {
        public int[,] GetSymbol =>
            new int[,]
            {
                {'|',' ',' ',' ','|'},
                {'|','_','_','_','|'},
                {' ',' ',' ',' ','|'},
                {' ',' ',' ',' ','|'}
            };
        public override string ToString()
        {
            return "4";
        }
    }

    class Five : ISymbol
    {
        public int[,] GetSymbol =>
            new int[,]
            {
                {'-','-','-','-','-'},
                {'|','_','_','_',' '},
                {' ',' ',' ',' ','|'},
                {'_','_','_','_','|'}
            };
        public override string ToString()
        {
            return "5";
        }
    }
}
