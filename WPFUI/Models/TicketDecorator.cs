using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFUI.Models
{
    public abstract class TicketDecorator : TicketModel //Abstract class to be inherited by other decorators
    {
        public abstract override string TicketDisplay { get; } //Override TicketDisplay string to update contents of ticket
    }
}
