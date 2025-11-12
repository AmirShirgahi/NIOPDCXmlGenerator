using System;

namespace NIOPDCXmlGenerator.Models
{
    public class Visit
    {
        public int VisitId { get; set; }
        public int VisitNO { get; set; }
        public int PatientId { get; set; }
        public DateTime VisitDate { get; set; }
        public DateTime? BookletExpiryDate { get; set; }
        public string? PrescriptionPageNo { get; set; }
        public int TotalQuantity { get; set; }
        public long TotalPatientShare { get; set; }
        public long TotalCompanyShare { get; set; }
        public long TotalAmount { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}