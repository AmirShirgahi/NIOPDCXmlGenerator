using System;

namespace NIOPDCXmlGenerator.Models
{
    public class ServiceItem
    {
        public int ServiceId { get; set; }
        public string Title { get; set; } = string.Empty;
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }
    }

}
