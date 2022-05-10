using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFUI.Models
{
    public class FrontAdder : TicketDecorator //Inherits from the TicketDecorator class
    {
        private readonly TicketModel _ticket; //Local ticket variable

        public FrontAdder(TicketModel ticket) //Constructor function executed when an instance of this class is created. Takes one parameter - the ticket to add the Front Row Seats to.
        {
            _ticket = ticket; //Set the local variable to the one passed into the constructor
        }
        public override string TicketDisplay => _ticket.TicketDisplay + "\n+ FRONT ROW SEAT"; //Adds the front row seat text to the ticket display string

        public override double Cost() //Override cost
        {
            return 15 + _ticket.Cost(); //Take the current cost, and add £15 to it
        }

    }
}
