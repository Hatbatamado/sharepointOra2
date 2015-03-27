using SolutionOra2.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SolutionOra2.Web
{
    public class Converter
    {
        public static List<IdoBejelentesViewModel> ToIdobejelentesVM(List<IdoBejelentes> iblist)
        {
            List<IdoBejelentesViewModel> result = new List<IdoBejelentesViewModel>();
            foreach (IdoBejelentes item in iblist)
            {
                result.Add(new IdoBejelentesViewModel(item));
            }

            return result;
        }
    }
}