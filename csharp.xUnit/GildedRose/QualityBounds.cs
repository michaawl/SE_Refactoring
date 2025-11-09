using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRoseKata
{
    public static class QualityBounds
    {
        public const int Min = 0;
        public const int Max = 50;

        public static int Clamp(int q) => Math.Max(Min, Math.Min(Max, q));
    }
}
