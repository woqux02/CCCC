using System;
using System.Collections.Generic;

namespace Packt.Shared
{
    public class DefaultVar
    {
        public DateTime BuyTime;
        public string Name;
        public int Number;

        public DefaultVar() 
        {
            BuyTime = default;
            Name = default;
            Number = default;
        }
    }
}