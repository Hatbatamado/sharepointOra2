using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SolutionOra2.DAL;

namespace SolutionOra2.BLL
{
    public class IdobejelentesBLL
    {
        public static void SaveIdoBejelentes(int? ID, DateTime startdate, int jogcimId)
        {
            using (SQLTraining02Entities db = new SQLTraining02Entities())
            {
                IdoBejelentes ib = null;
                if (ID == null)
                    ib = new IdoBejelentes();
                else
                {
                    //db lekérdezés getbyid
                    ib = (from b in db.IdoBejelentes
                          where b.ID == ID
                          select b).Single();

                    //ib = db.IdoBejelentes.Where(k => k.ID == ID).Single();
                }

                ib.StartDate = startdate;
                ib.Jogcim = (from b in db.Jogcim
                             where b.ID == jogcimId
                             select b).Single();
                //ib.Jogcim = db.Jogcim.Where(j => j.ID == jogcimId).Single();

                if (ID == null)
                    db.IdoBejelentes.Add(ib);

                db.SaveChanges();
            }

        }

        public static IdoBejelentes GetById(int id)
        {
            using (SQLTraining02Entities db = new SQLTraining02Entities())
            {
                IdoBejelentes ib = null;
                //db lekérdezés getbyid
                ib = (from b in db.IdoBejelentes
                      where b.ID == id
                      select b).Single();
                return ib;
                //ib = db.IdoBejelentes.Where(k => k.ID == ID).Single();

            }
        }

        public static List<IdoBejelentes> GetAll(SQLTraining02Entities db)
        {
                return db.IdoBejelentes.ToList();
        }

        public static List<Jogcim> GetAll()
        {
            using (SQLTraining02Entities db = new SQLTraining02Entities())
            {
                return db.Jogcim.ToList();
            }
        }
    }
}
