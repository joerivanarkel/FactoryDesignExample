using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FactoryDesignExample.Wrestlers
{
    public class Syuri : Wrestler
    {
        public string GetFaction()
        {
            return "Donna del Mundo";
        }

        public string GetGender()
        {
            return "Female";
        }

        public string GetName()
        {
            return "Syuri Kondo";
        }

        public string GetTitles()
        {
            return "World of Stardom";
        }
    }
}