using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFUI.Models
{
    public class ChildTicket : TicketModel //Inherits from the TicketModel abstract class
    {
        public ChildTicket() //Constructor function executed when an instance of this class is created
        {
            TicketDisplay = "===========\nCHILD TICKET\n==========="; //Sets the ticket display string
        }

        public override double Cost() //Overrides the cost method
        {
            return 5; //The cost of a child ticket is £5
        }

    }
}
