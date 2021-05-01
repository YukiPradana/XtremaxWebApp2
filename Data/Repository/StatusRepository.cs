using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XtremaxWebApp2.Data.DataModel;

namespace XtremaxWebApp2.Data.Repository
{
    public class StatusRepository : IStatusRepository
    {
        private readonly ApplicationDbContext _context;
        public IEnumerable<Status> GetAllStatus()
        {
            List<Status>statusList= _context.Status.ToList();

            return statusList;
        }

        public Status GetStatusById(int id)
        {
            Status status = _context.Status.FirstOrDefault(s => s.Id == id);

            return status;
        }

        bool IRepository.SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}
