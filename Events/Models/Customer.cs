using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Events.Models
{
    public class Customer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name ="Email Address")]
        [Column("Customer ID")]
        public string EmailID { get; set; }
        [Column("Name")]
        [Display(Name = "First Name")]

        public string FirstName { get; set; }
        public virtual ICollection<Event> Events { get; set; }
    }
}
