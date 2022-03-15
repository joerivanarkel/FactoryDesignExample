using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FactoryDesignExample.Wrestlers
{
    public class Utami : Wrestler
    {
        public string GetFaction()
        {
            return "Queen's Quest";
        }

        public string GetGender()
        {
            return "Female";
        }

        public string GetName()
        {
            return "Utami Hayashishita";
        }

        public string GetTitles()
        {
            return null;
        }
    }
}