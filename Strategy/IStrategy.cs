using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public interface IStrategy
    {
        object DoAlgo(object data);
    }
}
