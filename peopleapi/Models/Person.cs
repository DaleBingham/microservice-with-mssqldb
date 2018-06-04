using System;
using System.Collections.Generic;

namespace peopleapi.Models
{
    public partial class Person
    {
        public Guid PersonId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string WorkPhone { get; set; }
        public string CellPhone { get; set; }
        public string Email { get; set; }
        public string Twitter { get; set; }
        public string Linkedin { get; set; }
    }
}
