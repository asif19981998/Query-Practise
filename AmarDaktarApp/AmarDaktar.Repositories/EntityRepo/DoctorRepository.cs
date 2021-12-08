using AmarDaktar.DataBaseContext;
using AmarDaktar.Models.EntityModels;
using AmarDaktar.Repositories.Abastractions.IEntity;

using Base.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmarDaktar.Repositories.EntityRepo
{
    public class DoctorRepository: BaseRepository<Doctor>,IDoctorRepository
    {
        private AmarDaktarDbContext _db;
        public DoctorRepository(AmarDaktarDbContext db) : base(db)
        {
            _db = db;
        }



        public  IEnumerable<Doctor> GetApprovedData()
        {
           return _db.Doctors.ToList().Where(d => d.IsApproved == true);
            
        }
        public IEnumerable<Doctor> GetNotApprovedData()
        {
            return _db.Doctors.ToList().Where(d => d.IsApproved == false); ;

        }


        public  IEnumerable<Doctor> GetDataUsingQuery()
        {
            //return from c in _db.Doctor where c.YearsOfExperience < 5 select c;
            //return _db.Doctors.Where(c => c.YearsOfExperience < 5).ToList();
            return from c in _db.Doctors where c.YearsOfExperience < 5 orderby  c.Id descending select c;
        }
    }


}
