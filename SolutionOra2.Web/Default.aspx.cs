using SolutionOra2.BLL;
using SolutionOra2.DAL;
using SolutionOra2.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SolutionOra2.Web.Utility;

namespace SolutionOra2.Web
{
    public partial class Default : System.Web.UI.Page
    {
        public int? Id
        {
            get
            {
                return (int?)ViewState["Id"];
            }
            set
            {
                ViewState["Id"] = value;
            }
        }

        public List<IdoBejelentesViewModel> list
        {
            get
            {
                return (List<IdoBejelentesViewModel>)ViewState["ID"];
            }
            set
            {
                ViewState["Id"] = value;
            }
        }

        public class teszt
        {
            public int szam {get;set;}
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            //lekérem

            

            //List<teszt> l = new List<teszt>();
            //l.Add(new teszt() { szam = 5 });
            //l.Add(new teszt() { szam = 6 });
            //rp1.DataSource = l;
            //rp1.DataBind();


            if (!Page.IsPostBack)
            {
                SQLTraining02Entities db = new SQLTraining02Entities();

                List<IdoBejelentes> list = IdobejelentesBLL.GetAll(db);
                listview.DataSource = Converter.ToIdobejelentesVM(list);
                listview.DataBind();
                if (Request.QueryString["ID"] != null)
                {
                    Id = Int32.Parse(Request.QueryString["ID"]);
                    IdoBejelentes ib = IdobejelentesBLL.GetById(Id.Value);
                    TextBoxDatum.Text = ib.StartDate.ToString();
                }

    
                List<Jogcim> jogcimek = IdobejelentesBLL.GetAll();
                jogcimek.Insert(0, new Jogcim() { ID = 0, Title = "Kérem válasszon!" });
                jogcimBLL.DataSource = jogcimek;
                jogcimBLL.DataBind();
            }
            TextBox1.Text = Statusz.Jovahagyva.ToDisplayString();
        }

        protected void SaveButton_Click(object sender, EventArgs e)
        {
            if (jogcimBLL.SelectedValue == "0")
                throw new Exception("Nem töltötted ki!");
            if (Page.IsValid)
                IdobejelentesBLL.SaveIdoBejelentes(Id,
                    DateTime.Parse(TextBoxDatum.Text), Convert.ToInt32(jogcimBLL.SelectedValue));
        }

        protected void CustomValidatorDatum_ServerValidate(object source, ServerValidateEventArgs args)
        {
            try
            {
                if (String.IsNullOrEmpty(TextBoxDatum.Text))
                    CustomValidatorDatum.ErrorMessage = "Üres";
                DateTime d = DateTime.Parse(TextBoxDatum.Text);
            }
            catch (Exception)
            {
                args.IsValid = false;
            }
        }

    }
}