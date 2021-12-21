using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using REQGEST.Areas.Identity.Data;
using REQGEST.Areas.Identity.Pages.Account.Manage;

namespace REQGEST.Data
{
    public class DbInitializer
    {
        public static void Initialize(ReqGestDbContext context)
        {


            context.Database.EnsureCreated();

            //if (context.Users.Any())
            //{
            //    return;   // DB has been seeded
            //}

            var hasher = new PasswordHasher<IdentityUser>();

            var user = new AplicationUser { UserName = "administrator@reqgest.com", Name = "Administrator", Email = "administrator@reqgest.com", IdentificationDocument = "000000000000000", FiscalNumber = 000000000, IBAN = "000000000000000000000000000000", ContactNumber = "000000000", EmergencyNumber = "000000000", Adress = "Not relevant", PostalCode = "0000-000", City = "NotRelevant", State = "Not Relevant", Country = "Not Relevant", BirthDate = DateTime.Parse("2000-01-01"), Nacionality = "00", CivilStatus = "oooo", PasswordHash = hasher.HashPassword(null, "Administrator"), NormalizedUserName="ADMINISTRATOR@REQGEST.COM", LockoutEnabled = true };

            Console.WriteLine(hasher.HashPassword(null, "Administrator"));


            context.Users.Add(user);
            context.SaveChanges();

            var role = new IdentityRole[]
            {
                new IdentityRole {Name="Administrator"},
                new IdentityRole {Name="Coordinator" },
                new IdentityRole {Name="Collaborator"}
            };

            foreach (IdentityRole r in role)
            {
                context.Roles.Add(r);
            }
        }
    }
}
