using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp.Views
{
    internal interface ICustomersView
    {
        string CustomersId { get; set; }
        string CustomersDocNum { get; set; }
        string CustomersFirstName { get; set; }
        string CustomersLastName { get; set; }
        string CustomersAddress { get; set; }
        string CustomersBirthday { get; set; }
        string CustomersPhoneNumber { get; set; }
        string CustomersEmail { get; set; }


        string SearchValue { get; set; }
        bool IsEdit { get; set; }
        bool IsSuccessful { get; set; }
        string Message { get; set; }


        event EventHandler SearchEvent; 
        event EventHandler AddNewEvent; 
        event EventHandler EditEvent; 
        event EventHandler DeleteEvent; 
        event EventHandler SaveEvent; 
        event EventHandler CancelEvent;

        void SetCustomersListBildingSource(BindingSource CustomersList);

        void Show();
    }
}
