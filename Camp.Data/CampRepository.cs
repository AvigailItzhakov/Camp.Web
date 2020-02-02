using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Camp.Data
{
   public class CampRepository
    {
        private string _connectionString;
        public CampRepository(string connectionString)
        {
            _connectionString = connectionString;

        }
        public void AddCamper(Camper c)
        {
            using (var context = new CampContext(_connectionString))
            {
                context.Campers.Add(c);
               
                context.SaveChanges();
              

            }

        }
        public Camper GetCamperInfo(int id)
        {
            using (var context = new CampContext(_connectionString))

            {
                return context.Campers.FirstOrDefault(i => i.Id == id);
            }
        }
        public IEnumerable<Camper> GetCampers(int year)
        {
            using (var context = new CampContext(_connectionString))
            {
                return context.Campers.Where(i=>i.Year==year).ToList();
            }
        }

    }
}
