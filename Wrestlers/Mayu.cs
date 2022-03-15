using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FactoryDesignExample.Wrestlers
{
    public class Mayu : Wrestler
    {
        public string GetFaction()
        {
            return "Stars";
        }

        public string GetGender()
        {
            return "Female";
        }

        public string GetName()
        {
            return "Mayu Iwatani";
        }

        public string GetTitles()
        {
            return null;
        }
    }
}