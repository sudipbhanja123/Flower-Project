using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccessLayer
{
    public class UserDetails
    {
        public Guid UserId = Guid.NewGuid();
        public string ExistingId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string IpAddress { get; set; }
        public DateTime RegistrationDate { get; set; }
        public string Gender { get; set; }
        public Guid AddressId = Guid.NewGuid();
        public string AddressLine { get; set; }
        public string LandMark { get; set; }
        public string CityOrVillage { get; set; }
        public int Pincode { get; set; }
        public string PrimaryPhoneNumber { get; set; }
        public string SecondaryPhoneNumber { get; set; }
        public string DeliveryToName { get; set; }
        public int IsPrimaryAddress { get; set; }
        public int IsSecondaryAddress { get; set; }

    }
}
