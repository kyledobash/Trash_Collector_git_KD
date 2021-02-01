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

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Address { get; set; }

        public int ZipCode { get; set; }

        public string State { get; set; }

        public double Balance { get; set; }

        public string WeeklyPickupDay { get; set; }

        public DateTime OneTimePickup { get; set; }

        public DateTime StartSuspendService { get; set; }

        public DateTime EndSuspendService { get; set; }

    }
}
