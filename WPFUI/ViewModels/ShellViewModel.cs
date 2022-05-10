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
        public ShellViewModel() //Constructor function executed at beginning
        {
            Categories.Add(new CategoryModel { Name = "Child Ticket - £5" , Ticket = new ChildTicket()}); //Add new category objects to the list of categories. The Name value is how it'll be represented in the dropdown, the Ticket value is the ticket object that will be created when this option is selected.
            Categories.Add(new CategoryModel { Name = "Adult Ticket - £10", Ticket = new AdultTicket()});
            Categories.Add(new CategoryModel { Name = "Member Ticket - £7.50", Ticket = new MemberTicket()});
        }

        private int _quantity = 0; //The number of tickets to be purchased
        public int Quantity //Public version of quantity variable with getters and setters to update private variable
        {
            get { return _quantity; } //Return number of tickets
            set { _quantity = value;  //Update private variable number of tickets
                NotifyOfPropertyChange(() => Quantity); //Update bound objects
                NotifyOfPropertyChange(() => TicketPrice); //Changing quantity updates the price - update bound objects
                NotifyOfPropertyChange(() => FullTicket);  //Changing quantity updates the ticket contents - update bound objects
            } 
        }

        private TicketModel Ticket; //The Ticket object to be printed
        public string FullTicket //The contents to be displayed on screen
        {
            get { if (Ticket != null) { return Ticket.TicketDisplay+"\nx "+Quantity; } else { return ""; } } //If a ticket has been created, return the TicketDisplay attribute of the ticket object. Otherwise, return an empty string
        }

        public double TicketPrice //Variable to store the price of the current Ticket object
        {
            get { if (Ticket != null) { return Ticket.Cost()*Quantity; } else { return 0; } } //If a ticket has been created, return the price of the ticket multiplied by the number of tickets purchased. Otherwise, return 0.
        }

        private CategoryModel _category; //Used to store the currently selected category
        public CategoryModel Category //Public variant of category variable with getters and setters
        {
            get { return _category; } //Return the value of _category
            set
            {
                _category = value; //Update the private _category value
                if (_category!=null) //If the category is actually a category
                {
                    Ticket = _category.Ticket; //Update the Ticket object to reflect this category's object for a newly created ticket
                }

                TicketPrinted = "Hidden"; //As a new ticket has been created, hide the printed ticket display
                Quantity = 1; //As a new ticket has been created, reset the quantity to 1

                FrontButtonAvailable = true; //Activate the Front Row Seat button.
                PrintButtonAvailable = true; //Activate the Print button.
                ResetButtonAvailable = true; //Activate the Reset button.
                PieButtonAvailable = true; //Activate the Pint and a Pie button.
                TourButtonAvailable = true; //Activate the Tour button.
                SliderAvailable = true; //Activate the quantity slider.

                NotifyOfPropertyChange(() => FullTicket); //Adjusting the category updates the ticket description - update bound objects
                NotifyOfPropertyChange(() => TicketPrice); //Adjusting the category updates the ticket price - update bound objects
                NotifyOfPropertyChange(() => Category); //Adjusting the category updates the category - update bound objects
            }
        }

        private BindableCollection<CategoryModel> _categories = new BindableCollection<CategoryModel>(); //Bindable collection bound to the categories dropdown list. Contains a list of CategoryModel objects

        public BindableCollection<CategoryModel> Categories //Public variant of category collection
        {
            get { return _categories; } //Return the list of category models
            set { _categories = value; } //Updates the private categories variable to the given value
        }

        private string _ticketPrinted = "Hidden"; //Bound to the ticket display, dictates whether the ticket is visible or hidden
        public string TicketPrinted //Public variant of ticket printed
        {
            get { return _ticketPrinted; } //Return whether or not the ticket should be visible
            set
            {
                _ticketPrinted = value; //Updates the private variable to represent the given value
                NotifyOfPropertyChange(() => TicketPrinted); //Update bound objects on property change
            }
        }

        private Boolean _printButtonAvailable = false; //Boolean variable bound to the print button - when true, the button can be pressed.
        public Boolean PrintButtonAvailable //Public variant
        {
            get { return _printButtonAvailable; } //Return whether or not the print button can be pressed
            set
            {
                _printButtonAvailable = value; //Updates the private variable to represent the given value
                NotifyOfPropertyChange(() => PrintButtonAvailable); //Update bound objects on property change
            }
        }

        private Boolean _resetButtonAvailable = false; //Boolean variable bound to the reset button - when true, the button can be pressed.
        public Boolean ResetButtonAvailable //Public variant
        {
            get { return _resetButtonAvailable; } //Return whether or not the reset button can be pressed
            set
            {
                _resetButtonAvailable = value; //Updates the private variable to represent the given value
                NotifyOfPropertyChange(() => ResetButtonAvailable); //Update bound objects on property change
            }
        }

        private Boolean _pieButtonAvailable = false; //Boolean variable bound to the pie button - when true, the button can be pressed.
        public Boolean PieButtonAvailable //Public variant
        {
            get { return _pieButtonAvailable; } //Return whether or not the reset button can be pressed
            set
            {
                _pieButtonAvailable = value; //Updates the private variable to represent the given value
                NotifyOfPropertyChange(() => PieButtonAvailable); //Update bound objects on property change
            }
        }

        private Boolean _frontButtonAvailable = false; //Boolean variable bound to the front button - when true, the button can be pressed.
        public Boolean FrontButtonAvailable //Public variant
        {
            get { return _frontButtonAvailable; } //Return whether or not the front row seats button can be pressed
            set
            {
                _frontButtonAvailable = value; //Updates the private variable to represent the given value
                NotifyOfPropertyChange(() => FrontButtonAvailable); //Update bound objects on property change
            }
        }
        private Boolean _tourButtonAvailable = false; //Boolean variable bound to the tour button - when true, the button can be pressed.
        public Boolean TourButtonAvailable //Public variant
        {
            get { return _tourButtonAvailable; } //Return whether or not the tour of the grounds button can be pressed
            set
            {
                _tourButtonAvailable = value; //Updates the private variable to represent the given value
                NotifyOfPropertyChange(() => TourButtonAvailable); //Update bound objects on property change
            }
        }

        private Boolean _sliderAvailable = false; //Boolean variable bound to the print button - when true, the button can be pressed.
        public Boolean SliderAvailable //Public variant
        {
            get { return _sliderAvailable; } //Return whether or not the quantity slider can be used
            set
            {
                _sliderAvailable = value; //Updates the private variable to represent the given value
                NotifyOfPropertyChange(() => SliderAvailable); //Update bound objects on property change
            }
        }

        public void Reset() //Reset function bound to pressing the Reset button
        {
            Category = null; //Resets the category to nothing
            Ticket = null; //Resets the ticket to nothing
            TicketPrinted = "Hidden"; //Hides the ticket display
            Quantity = 0; //Resets the quantity to 0

            ResetButtonAvailable = false; //Disables the reset button 
            PrintButtonAvailable = false; //Disables the print button
            PieButtonAvailable = false; //Disables the pie button
            TourButtonAvailable = false; //Disables the tour button
            FrontButtonAvailable = false; //Disables the front button
            SliderAvailable = false; //Disables the quantity slider
         
            NotifyOfPropertyChange(() => Ticket); //Resetting changes the ticket object - update bound objects
            NotifyOfPropertyChange(() => FullTicket); //Resetting changes the ticket description - update bound objects
            NotifyOfPropertyChange(() => TicketPrice); //Resetting changes the ticket price - update bound objects
        }

        public void AddPieAndPint() //Pie and pint function bound to pressing the pie and pint button
        {
            PieButtonAvailable = false; //Disables the pie button
            Ticket = new PieAdder(Ticket); //Uses the PieAdder decorator to add a pie and a pint to the ticket object

            NotifyOfPropertyChange(() => FullTicket); //Adding a pie and a pint changes the ticket description - update bound objects
            NotifyOfPropertyChange(() => TicketPrice); //Adding a pie and a pint changes the ticket price - update bound objects
        }

        public void AddTour() //Add tour function bound to pressing the add tour button
        {
            TourButtonAvailable = false; //Disables the tour button
            Ticket = new TourAdder(Ticket); //Use the TourAdder decorator to add a tour of the grounds to the ticket object

            NotifyOfPropertyChange(() => FullTicket); //Adding a tour changes the ticket description - update bound objects
            NotifyOfPropertyChange(() => TicketPrice); //Adding a tour changes the ticket price - update bound objects
        }

        public void AddFrontRowSeats() //Add front row seats function bound to pressing the add front row seats button
        {
            FrontButtonAvailable = false; //Disables the front row seats button
            Ticket = new FrontAdder(Ticket); //Uses the FrontAdder decorator to add a front row seat to the ticket object

            NotifyOfPropertyChange(() => FullTicket); //Adding a front row seat changes the ticket description - update bound objects
            NotifyOfPropertyChange(() => TicketPrice); //Adding a front row seat changes the ticket price - update bound objects
        }

        public void Print() //Print function bound to pressing the print button
        {
            TourButtonAvailable = false; //Disable the tour button
            PieButtonAvailable = false; //Disable the pint and a pint button
            ResetButtonAvailable = true; //Disable the reset button
            PrintButtonAvailable = false; //Disable the print button
            FrontButtonAvailable = false; //Disable the front row seat button
            SliderAvailable = false; //Disable the quantity slider

            TicketPrinted = "Visible"; //Make the ticket display visible
        }
    }
}
