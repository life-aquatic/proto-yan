using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proto.DIscratch
{
    public class DataContext
    {
        static readonly Random _rand = new Random();

        public DataContext()
        {
            RowCount = _rand.Next(1, 1_000_000_000);
        }
        public int RowCount { get; }
    }
}
