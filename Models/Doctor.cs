using System;

namespace NIOPDCXmlGenerator.Models
{
    public class Doctor
    {
        public string NPCode { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalCode { get; set; }
        public string Mobile { get; set; }
        public int Gender { get; set; }
        public string Specialty { get; set; } 
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public string FullName => $"{FirstName} {LastName}";
        public string GenderText => Gender == 1 ? "مرد" : "زن";
    }
}
