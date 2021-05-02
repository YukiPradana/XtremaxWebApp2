using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XtremaxWebApp2.Data.DataModel;

namespace XtremaxWebApp2.Data.Repository
{
    public class TicketRepository : ITicketRepository
    {
        private readonly ApplicationDbContext _context;

        public TicketRepository(ApplicationDbContext context)
        {
            _context = context;

        }

        public void CreateTicket(Ticket ticket)
        {
            if (ticket==null)
            {
                throw new ArgumentNullException(nameof(ticket));
            }
            _context.Tickets.Add(ticket);
        }

        public void DeleteTicket(Ticket ticket)
        {
            if (ticket == null)
            {
                throw new ArgumentNullException(nameof(ticket));
            }
            _context.Tickets.Remove(ticket);
        }

        public IEnumerable<Ticket> GetAllTicket()
        {

            return _context.Tickets.ToList();
        }

        public IEnumerable<Ticket> GetAssignedTicket()
        {
            return _context.Tickets.Where(x=>x.AsigneeId!=null).ToList();
            
        }

        public IEnumerable<Ticket> GetCreatedTicket(IdentityUser user)
        {
            return _context.Tickets.Where(x => x.CreatorId.Equals(user.Id)).ToList();
        }

        public Ticket GetTicketById(int id)
        {
            return _context.Tickets.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Ticket> GetTicketByStatus(Status status)
        {
            throw new NotImplementedException();
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void UpdateTicket(Ticket ticket)
        {
            Ticket existingTicket = GetTicketById(ticket.Id);

            if (existingTicket != null)
            {
                existingTicket.StatusId = ticket.StatusId;
                existingTicket.AsigneeId = ticket.AsigneeId;
                existingTicket.CategoryId = ticket.CategoryId;

                _context.Tickets.Update(existingTicket);
            }
        }
    }
}
