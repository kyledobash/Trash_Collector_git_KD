using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Trash_Collector_actual_KD.Models
{
    public class Customer
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

        public string Address { get; set; }

        [Display(Name = "Zip Code")]
        public string ZipCode { get; set; }

        public string State { get; set; }

        public double Balance { get; set; }

        [Display(Name = "Weekly Pick-up Day")]
        public string WeeklyPickupDay { get; set; }

        [Display(Name = "One-Time Pick-up (Optional)")]
        public DateTime? OneTimePickup { get; set; }

        [Display(Name = "Suspend Service Start Date (Optional)")]
        public DateTime? StartSuspendService { get; set; }

        [Display(Name = "Suspend Service End Date (Optional)")]
        public DateTime? EndSuspendService { get; set; }

        public bool PickupCompleted { get; set; }
    }
}
