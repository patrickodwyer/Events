using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Events.Models
{
    public class Event
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        [Column("EventID")]
        public int EventID { get; set; }

        public string EmailID { get; set; }

        [Display(Name = "Event Type")]
        [Column("Event Name")]
        public String Description { get; set; }

        [Display(Name = "Price (€)")]
        [Column("Price")]
        public double Price { get; set; }

        public DateTime Date { get; set; }
        public virtual Customer Customer { get; set; }                     // euro
    }

    // an product item in a shopping cart
    public class BookedEvent : Event
    {
        public int Quantity { get; set; }
    }

}
