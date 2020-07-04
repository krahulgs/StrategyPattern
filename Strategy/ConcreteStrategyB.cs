using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    class ConcreteStrategyB : IStrategy
    {
        public object DoAlgo(object data)
        {
            var list = data as List<string>;
            list.Sort();
            list.Reverse();
            return list;
        }
    }
}
