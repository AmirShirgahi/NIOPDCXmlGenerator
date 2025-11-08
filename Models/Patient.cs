using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NIOPDCXmlGenerator.Models
{
    public class Patient
    {
        public int PatientId { get; set; }
        public string PersonnelCode { get; set; } = string.Empty;
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? NationalCode { get; set; }
        public string? Mobile { get; set; }
        public int Gender { get; set; }
        public bool IsRetired { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
