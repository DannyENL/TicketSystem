using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFUI.Models
{
    public class CategoryModel //Model used to represent a category
    {
        public string Name { get; set; } //Name of the category, e.g. Child, Adult, etc. This is displayed in the dropdown
        public TicketModel Ticket { get; set; } //The ticket object that selecting this category will create
    }
}
