using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFUI.Models
{
    public class TourAdder : TicketDecorator
    {
        private readonly TicketModel _ticket;

        public TourAdder(TicketModel ticket)
        {
            _ticket = ticket;
        }
        public override string TicketDisplay => _ticket.TicketDisplay + "\n+ TOUR OF THE GROUNDS";

        public override double Cost()
        {
            return 20 + _ticket.Cost();
        }

    }
}
