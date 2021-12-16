using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace REQGEST.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the AplicationUser class
    [Index(nameof(IdentificationDocument), IsUnique =true)]
    [Index(nameof(FiscalNumber), IsUnique = true)]
    [Index(nameof(Email), IsUnique = true)]
    public class AplicationUser : IdentityUser
    {
        [PersonalData]
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [PersonalData]
        [Required]
        [MaxLength(50)]
        public string Email { get; set; }

        [PersonalData]
        [Required]
        [MaxLength(20)]
        public string IdentificationDocument { get; set; }

        [PersonalData]
        [Required]
        [MaxLength(9)]
        public int FiscalNumber { get; set; }

        [PersonalData]
        [Required]
        [MaxLength(35)]
        public string IBAN { get; set; }

        [PersonalData]
        [Required]
        [MaxLength(17)]
        public string ContactNumber { get; set; }

        [PersonalData]
        [Required]
        [MaxLength(17)]
        public string EmergencyNumber { get; set; }

        [PersonalData]
        [Required]
        [MaxLength(100)]
        public string Adress { get; set; }

        [PersonalData]
        [Required]
        [MaxLength(10)]
        public string PostalCode { get; set; }

        [PersonalData]
        [Required]
        [MaxLength(40)]
        public string City { get; set; }

        [PersonalData]
        [Required]
        [MaxLength(40)]
        public string State { get; set; }

        [PersonalData]
        [Required]
        [MaxLength(40)]
        public string Country { get; set; }

        [PersonalData]
        [Required]
        public DateTime BirthDate { get; set; }

        [PersonalData]
        [MaxLength(50)]
        public string Nacionality { get; set; }

        [PersonalData]
        [MaxLength(15)]
        public string CivilStatus { get; set; }

    }
}
