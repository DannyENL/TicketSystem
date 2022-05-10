using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFUI.Models
{
    public class MemberTicket : TicketModel //Inherits from the TicketModel abstract class
    {
        public MemberTicket() //Constructor function executed when an instance of this class is created
        {
            TicketDisplay = "===========\nMEMBER TICKET\n==========="; //Sets the ticket display string
        }

        public override double Cost() //Overrides the cost method
        {
            return 7.50; //The cost of a member's ticket is £7.50
        }

    }
}
