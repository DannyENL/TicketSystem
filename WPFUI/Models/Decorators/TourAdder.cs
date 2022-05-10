using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFUI.Models
{
    public class TourAdder : TicketDecorator //Inherits from the TicketDecorator class
    {
        private readonly TicketModel _ticket; //Local ticket variable

        public TourAdder(TicketModel ticket) //Constructor function executed when an instance of this class is created. Takes one parameter - the ticket to add the Tour to.
        {
            _ticket = ticket; //Set the local variable to the one passed into the constructor
        }
        public override string TicketDisplay => _ticket.TicketDisplay + "\n+ TOUR OF THE GROUNDS"; //Adds the tour of the grounds text to the ticket display string

        public override double Cost() //Override cost
        {
            return 20 + _ticket.Cost(); //Take the current cost, and add £20 to it
        }

    }
}
