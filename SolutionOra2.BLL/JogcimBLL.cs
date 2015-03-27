using SolutionOra2.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionOra2.BLL
{
    class JogCimBLL
    {
        public static List<Jogcim> GetAll()
        {
            using(SQLTraining02Entities db = new SQLTraining02Entities())
            {
                return db.Jogcim.ToList();
            }
        }
    }
}
