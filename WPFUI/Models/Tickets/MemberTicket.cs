using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFUI.Models
{
    public class MemberTicket : TicketModel
    {
        public MemberTicket()
        {
            TicketDisplay = "===========\nMEMBER TICKET\n===========";
        }

        public override double Cost()
        {
            return 1.99;
        }

    }
}
