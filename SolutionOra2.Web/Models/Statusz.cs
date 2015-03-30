using SolutionOra2.Web.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SolutionOra2.Web.Models
{
    public enum Statusz
    {
        [EnumDisplayStringAttribute("Jóváhagyva")]
        Jovahagyva,
        [EnumDisplayStringAttribute("Rögzítve")]
        Rogzitve,
        [EnumDisplayStringAttribute("Elutasítva")]
        Elutasitva
    }
}