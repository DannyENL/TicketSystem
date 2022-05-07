using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFUI.Models
{
    public class AdultTicket : TicketModel
    {
        public AdultTicket()
        {
            TicketDisplay = "===========\nADULT TICKET\n===========";
        }

        public override double Cost()
        {
            return 1.99;
        }

    }
}
