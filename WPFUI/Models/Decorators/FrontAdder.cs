using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFUI.Models
{
    public class FrontAdder : TicketDecorator
    {
        private readonly TicketModel _ticket;

        public FrontAdder(TicketModel ticket)
        {
            _ticket = ticket;
        }
        public override string TicketDisplay => _ticket.TicketDisplay + "\n+ FRONT ROW SEAT";

        public override double Cost()
        {
            return 15 + _ticket.Cost();
        }

    }
}
