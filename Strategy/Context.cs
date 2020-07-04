using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class Context
    {
        private IStrategy _strategy;

        public Context()
        {

        }
        //public Context(IStrategy strategy)
        //{
        //    _strategy = strategy;
        //}

        public void SetStrategy(IStrategy strategy)
        {
            this._strategy = strategy;
        }
        public void DoSomeBusinessLogic()
        {
            var result = this._strategy.DoAlgo(new List<String> { "a", "v", "b", "f", "d", "h" });
            string resulStr = string.Empty;
            foreach (var element in result as List<string>)
            {
                resulStr += element + ' ';
            }
            Console.WriteLine(resulStr);
        }

    }
}
