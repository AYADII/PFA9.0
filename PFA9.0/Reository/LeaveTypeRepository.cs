using PFA9._0.Contracts;
using PFA9._0.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PFA9._0.Reository
{
    public class LeaveTypeRepository : ILeaveTypeRepository
    {
        private readonly ApplicationDbContext _db;
        public LeaveTypeRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        public bool Create(LeaveType entity)
        {
            _db.LeaveTypes.Add(entity);
            return Save();

        }

        public bool Delete(LeaveType entity)
        {
            _db.LeaveTypes.Remove(entity);
            return Save();
        }

        public ICollection<LeaveType> FindAll()
        {
            var LeaveTypes = _db.LeaveTypes.ToList();
            return LeaveTypes;
        }

        public LeaveType FindById(int id)
        {
            var FindLeaves = _db.LeaveTypes.Find(id);
            return FindLeaves;
        }

        public bool Save()
        {
           var changes= _db.SaveChanges();
            return changes>0;
        }

        public bool Update(LeaveType entity)
        {
            _db.LeaveTypes.Update(entity);
            return Save();
        }
    }
}
