using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SolutionOra2.Web.Models;

namespace SolutionOra2.Web
{
    public partial class Attekinto : System.Web.UI.Page
    {
        public class AttekintoViewModel
        {
            public List<Elem> BelsoLista { get; set; }
            public string HonapNeve { get; set; }

            public AttekintoViewModel(int Honap)
            {
                BelsoLista = new List<Elem>();
                for (int i = 1; i < DateTime.DaysInMonth(DateTime.Now.Year, Honap); i++)
                {
                    if (i % 2 == 0)
                        BelsoLista.Add(new Elem() { ElemOsztaly = "piros", Statusz= Statusz.Elutasitva });
                    else if (i % 3 == 0)
                        BelsoLista.Add(new Elem() { ElemOsztaly = "szurke", Statusz = Statusz.Rogzitve });
                    else
                        BelsoLista.Add(new Elem() { ElemOsztaly = "kek", Statusz = Statusz.Jovahagyva });
                }
            }

            public int Honap { get; set; }
        }

        public class Elem
        {
            public string ElemOsztaly { get; set; }
            public Statusz Statusz { get; set; }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            DateTimeFormatInfo minfo = new DateTimeFormatInfo();
            List<AttekintoViewModel> kulsoLista = new List<AttekintoViewModel>();
            for (int i = 1; i <= 12; i++ )
            {
                kulsoLista.Add(new AttekintoViewModel(i) { HonapNeve = minfo.GetMonthName(i) });
            }

            KulsoRepeater.DataSource = kulsoLista;
            KulsoRepeater.DataBind();
        }
    }
}