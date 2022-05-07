using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFUI.Models;

namespace WPFUI.ViewModels
{
    public class ShellViewModel : Conductor<object>
    {
        public ShellViewModel()
        {
            Categories.Add(new CategoryModel { Name = "Child Ticket" , Ticket = new ChildTicket()});
            Categories.Add(new CategoryModel { Name = "Adult Ticket", Ticket = new AdultTicket()});
            Categories.Add(new CategoryModel { Name = "Member Ticket", Ticket = new MemberTicket()});
        }

        private TicketModel Ticket;

        public string FullTicket
        {
            get { if (Ticket != null) { return Ticket.TicketDisplay; } else { return ""; } }
        }

        private CategoryModel _category;
        public CategoryModel Category
        {
            get { return _category; }
            set
            {
                _category = value;
                if (_category!=null)
                {
                    Ticket = _category.Ticket;
                }
                ResetButtonAvailable = true;
                PieButtonAvailable = true;
                TourButtonAvailable = true;
                TicketPrinted = "Hidden";
                FrontButtonAvailable = true;
                PrintButtonAvailable = true;
                NotifyOfPropertyChange(() => FullTicket);
                NotifyOfPropertyChange(() => Category);
            }
        }

        private BindableCollection<CategoryModel> _categories = new BindableCollection<CategoryModel>();

        public BindableCollection<CategoryModel> Categories
        {
            get { return _categories; }
            set { _categories = value; }
        }

        private Boolean _printButtonAvailable = false;
        public Boolean PrintButtonAvailable
        {
            get { return _printButtonAvailable; }
            set
            {
                _printButtonAvailable = value;
                NotifyOfPropertyChange(() => PrintButtonAvailable);
            }
        }

        private string _ticketPrinted = "Hidden";
        public string TicketPrinted
        {
            get { return _ticketPrinted; }
            set
            {
                _ticketPrinted = value;
                NotifyOfPropertyChange(() => TicketPrinted);
            }
        }

        private Boolean _resetButtonAvailable = false;
        public Boolean ResetButtonAvailable
        {
            get { return _resetButtonAvailable; }
            set
            {
                _resetButtonAvailable = value;
                NotifyOfPropertyChange(() => ResetButtonAvailable);
            }
        }

        private Boolean _pieButtonAvailable = false;
        public Boolean PieButtonAvailable
        {
            get { return _pieButtonAvailable; }
            set
            {
                _pieButtonAvailable = value;
                NotifyOfPropertyChange(() => PieButtonAvailable);
            }
        }

        private Boolean _frontButtonAvailable = false;
        public Boolean FrontButtonAvailable
        {
            get { return _frontButtonAvailable; }
            set
            {
                _frontButtonAvailable = value;
                NotifyOfPropertyChange(() => FrontButtonAvailable);
            }
        }
        private Boolean _tourButtonAvailable = false;
        public Boolean TourButtonAvailable
        {
            get { return _tourButtonAvailable; }
            set
            {
                _tourButtonAvailable = value;
                NotifyOfPropertyChange(() => TourButtonAvailable);
            }
        }

        public void Reset()
        {
            Category = null;
            ResetButtonAvailable = false;
            TicketPrinted = "Hidden";
            PrintButtonAvailable = false;
            PieButtonAvailable = false;
            TourButtonAvailable = false;
            FrontButtonAvailable = false;
        }

        public void AddPieAndPint()
        {
            PieButtonAvailable = false;
            Ticket = new PieAdder(Ticket);
            NotifyOfPropertyChange(() => FullTicket);
        }

        public void AddTour()
        {
            TourButtonAvailable = false;
            Ticket = new TourAdder(Ticket);
            NotifyOfPropertyChange(() => FullTicket);
        }

        public void AddFrontRowSeats()
        {
            FrontButtonAvailable = false;
            Ticket = new FrontAdder(Ticket);
            NotifyOfPropertyChange(() => FullTicket);
        }

        public void Print()
        {
            TourButtonAvailable = false;
            PieButtonAvailable = false;
            ResetButtonAvailable = true;
            PrintButtonAvailable = false;
            FrontButtonAvailable = false;
            TicketPrinted = "Visible";
        }
    }
}
