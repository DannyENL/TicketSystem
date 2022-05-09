using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFUI.Models
{
    public class PieAdder : TicketDecorator
    {
        private readonly TicketModel _ticket;

        public PieAdder(TicketModel ticket)
        {
            _ticket = ticket;
        }
        public override string TicketDisplay => _ticket.TicketDisplay + "\n+ A PIE AND A PINT";

        public override double Cost()
        {
            return 12.50 + _ticket.Cost();
        }

    }
}
