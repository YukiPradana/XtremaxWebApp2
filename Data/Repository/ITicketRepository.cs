using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XtremaxWebApp2.Data.DataModel;

namespace XtremaxWebApp2.Data.Repository
{
    interface ITicketRepository
    {
        IEnumerable<Ticket> GetAllTicket();
        Ticket GetTicketById(int id);
        IEnumerable<Ticket> GetCreatedTicket();
        IEnumerable<Ticket> GetAssignedTicket();
        IEnumerable<Ticket> GetTicketByStatus(Status status);

        void CreateTicket(Ticket ticket);
        void UpdateTicket(Ticket ticket);
        void DeleteTicket(Ticket ticket);
    }
}
