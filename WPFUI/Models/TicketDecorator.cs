using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFUI.Models
{
    public abstract class TicketDecorator : TicketModel
    {
        public abstract override string TicketDisplay { get; }
    }
}
