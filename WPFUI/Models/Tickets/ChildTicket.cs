using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFUI.Models
{
    public class ChildTicket : TicketModel
    {
        public ChildTicket()
        {
            TicketDisplay = "===========\nCHILD TICKET\n===========";
        }

        public override double Cost()
        {
            return 1.99;
        }

    }
}
