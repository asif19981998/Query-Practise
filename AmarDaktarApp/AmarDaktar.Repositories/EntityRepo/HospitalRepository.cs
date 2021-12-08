﻿using AmarDaktar.DataBaseContext;
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
    public class HospitalRepository : BaseRepository<Hospital>, IHospitalRepository
    {
        private AmarDaktarDbContext _db;
        public HospitalRepository(AmarDaktarDbContext db) : base(db)
        {
            _db = db;
        }

        public IEnumerable<Hospital> GetApprovedData()
        {
            return _db.Hospitals.ToList().Where(d => d.IsApproved == true);

        }
        public IEnumerable<Hospital> GetNotApprovedData()
        {
            return _db.Hospitals.ToList().Where(d => d.IsApproved == false); ;

        }
    }
}
