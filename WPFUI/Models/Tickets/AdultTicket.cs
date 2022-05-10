using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFUI.Models
{
    public class AdultTicket : TicketModel //Inherits from the TicketModel abstract class
    {
        public AdultTicket() //Constructor function executed when an instance of this class is created
        {
            TicketDisplay = "===========\nADULT TICKET\n==========="; //Sets the ticket display string
        }

        public override double Cost() //Overrides the cost method
        {
            return 10; //The cost of an adult ticket is £10
        }

    }
}
