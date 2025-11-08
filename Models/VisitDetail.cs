using System;

namespace NIOPDCXmlGenerator.Models
{
    public class VisitDetail
    {
        public int VisitDetailId { get; set; }
        public int VisitId { get; set; }
        public int ServiceId { get; set; }
        public int? TariffId { get; set; }
        public int Quantity { get; set; }
        public long UnitAmount { get; set; }
        public long PatientShare { get; set; }
        public long CompanyShare { get; set; }
        public long TotalAmount { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}