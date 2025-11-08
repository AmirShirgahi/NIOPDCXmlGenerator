using System;

namespace NIOPDCXmlGenerator.Models
{
    /// <summary>
    /// DTO برای نمایش لیست ویزیت‌ها در گرید (شامل اطلاعات بیمار برای نمایش)
    /// </summary>
    public class VisitListItem
    {
        public int VisitId { get; set; }
        public int PatientId { get; set; }
        public DateTime VisitDate { get; set; }
        public DateTime? BookletExpiryDate { get; set; }
        public string PrescriptionPageNo { get; set; }
        public int TotalQuantity { get; set; }
        public long TotalPatientShare { get; set; }
        public long TotalCompanyShare { get; set; }
        public long TotalAmount { get; set; }
        public DateTime CreatedAt { get; set; }

        // fields for display
        public string PersonnelCode { get; set; }
        public string PatientName { get; set; }
    }
}