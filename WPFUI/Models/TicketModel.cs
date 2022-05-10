using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFUI.Models
{
    public abstract class TicketModel //Abstract class to be inherited by other classes
    {
        public virtual string TicketDisplay { get; protected set; } = ""; //Used when printing the ticket
        public abstract double Cost(); //Abstract Cost method needs to be implemented by classes that inherit this one
    }
}
