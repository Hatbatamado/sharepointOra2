using SolutionOra2.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SolutionOra2.Web
{
    [Serializable]
    public class IdoBejelentesViewModel
    {
        public int ID { get; set; }
        public DateTime StartDate { get; set; }
        public String JogcimTitle { get; set; }
        
        public IdoBejelentesViewModel(IdoBejelentes ib)
        {
            ID = ib.ID;
            StartDate = ib.StartDate;
            JogcimTitle = ib.JogcimTitle;
        }
    }
}