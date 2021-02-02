using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Trash_Collector_actual_KD.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("IdentityUser")]

        public string IdentityUserId { get; set; }

        public IdentityUser IdentityUser { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Service Area Zip Code")]
        public int ServiceAreaZipCode { get; set; }

        [Display(Name = "Pending Pick-ups")]
        public List<Customer> PendingPickups { get; set; }

        [Display(Name = "Completed Pick-ups")]
        public List<Customer> CompletedPickups { get; set; }
    }
}
