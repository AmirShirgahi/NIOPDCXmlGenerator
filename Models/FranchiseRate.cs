using System;

namespace NIOPDCXmlGenerator.Models
{
    public class FranchiseRate
    {
        public int RateId { get; set; }
        public decimal RetiredPercentage { get; set; }  // درصد بازنشسته
        public decimal EmployeePercentage { get; set; } // درصد کارمند
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
