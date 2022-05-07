using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFUI.Models
{
    public abstract class TicketModel
    {
        public virtual string TicketDisplay { get; protected set; } = "";
        public abstract double Cost();
        
    }
}
