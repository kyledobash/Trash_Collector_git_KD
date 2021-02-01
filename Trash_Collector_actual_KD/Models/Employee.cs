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

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int ServiceAreaZipCode { get; set; }

        public List<Customer> PendingPickups { get; set; }

        public List<Customer> CompletedPickups { get; set; }
    }
}
