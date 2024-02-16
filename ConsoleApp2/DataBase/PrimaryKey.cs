using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.DataBaseSTO
{
    internal class PrimaryKey
    {
        static int _lastKey = 0;
        public int Key { get; }
        public PrimaryKey()
        {
            Key = _lastKey;
            _lastKey++;
        }
    }
}
