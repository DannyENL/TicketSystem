using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFUI.Models
{
    public class PieAdder : TicketDecorator //Inherits from the TicketDecorator class
    {
        private readonly TicketModel _ticket; //Local ticket variable

        public PieAdder(TicketModel ticket) //Constructor function executed when an instance of this class is created. Takes one parameter - the ticket to add the Pie and Pint to.
        {
            _ticket = ticket; //Set the local variable to the one passed into the constructor
        }
        public override string TicketDisplay => _ticket.TicketDisplay + "\n+ A PIE AND A PINT"; //Adds the pie and pint text to the ticket display string

        public override double Cost() //Override cost
        {
            return 12.50 + _ticket.Cost(); //Take the current cost, and add £12.50 to it
        }

    }
}
