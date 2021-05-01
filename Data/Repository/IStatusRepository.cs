using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XtremaxWebApp2.Data.DataModel;

namespace XtremaxWebApp2.Data.Repository
{
    interface IStatusRepository
    {
        IEnumerable<Status> GetAllStatus();
        Status GetStatusById(int id);
    }
}
