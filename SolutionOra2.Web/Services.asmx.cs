using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Services;
using System.Web.Services;
using System.Web.Script.Serialization;

namespace SolutionOra2.Web
{
    /// <summary>
    /// Summary description for Services
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class Services : System.Web.Services.WebService
    {

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string GetEvents(DateTime start, DateTime end)
        {
            List<Event> Events = new List<Event>();
            Events.Add(new Event { id = 2, title = "teszt", start = DateTime.Now, end = DateTime.Now.AddHours(5) });
            JavaScriptSerializer js = new JavaScriptSerializer();
            return js.Serialize(Events);
    }

    public class Event
    {
        public int id { get; set; }
        public String title { get; set; }
        public DateTime start { get; set; }
        public DateTime end { get; set; }
    }
}
