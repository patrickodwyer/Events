using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;

namespace Events.Models
{
    public class Booking
    {
        private List<BookedEvent> events;                             // collection of items 

        public Booking()
        {
            events = new List<BookedEvent>();
        }


        // add an item to the cart i.e. increase qty of that item in the cart
        // +
        public void AddEvent(BookedEvent occassion)
        {
            // code is unique
            var match = events.FirstOrDefault(i => i.EmailID.ToUpper(CultureInfo.CurrentCulture) == occassion.EmailID.ToUpper(CultureInfo.CurrentCulture));
            if (match == null)
            {
                events.Add(new BookedEvent() { EventID = occassion.EventID, Description = occassion.Description, Price = occassion.Price, Quantity = 1 });
            }
            else
            {
                match.Quantity++;                   // increase
            }
        }


        // calculate total price of cart
        public double CalculateTotalPrice()
        {
            return events.Sum(item => item.Price * item.Quantity);
        }
    }
    

}