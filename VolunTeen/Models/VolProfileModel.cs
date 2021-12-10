using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VolunTeen.Models
{
    public class VolProfileModel
    {
        public int ID { get; set; }
        [Required]
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public DateTime DOB { get; set; }
        public string Gender { get; set; }
        public string RacialInformation { get; set; }
        public string EthnicInformation { get; set; }
        public string Question1 { get; set; }
        public string Question2 { get; set; }
        public string StreetAddress1 { get; set; }
        public string StreetAddress2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public decimal ZipCode { get; set; }
        public string ContactPhone { get; set; }
        public string CellPhone { get; set; }
        public string CurrentlyEmployed { get; set; }
        public string PhysicalLimitation { get; set; }
        public string LimitationDescription { get; set; }
        public string Language { get; set; }
    }
}