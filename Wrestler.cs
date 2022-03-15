using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FactoryDesignExample
{
    public interface Wrestler
    {
        string GetName();
        string GetGender();
        string GetTitles();
        string GetFaction();
    }
}