using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FactoryDesignExample.Wrestlers;

namespace FactoryDesignExample
{
    public class WrestlingFactory
    {
        public Wrestler GetWrestler(string name)
        {
            if (name == "Utami Hayashishita")
            {
                return new Utami();
            }
            else if (name == "Syuri Kondo")
            {
                return new Syuri();
            }
            else if (name == "Mayu Iwatani")
            {
                return new Mayu();
            }
            return null;
        }
    }
}