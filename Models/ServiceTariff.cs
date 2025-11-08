using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NIOPDCXmlGenerator.Models
{

    public class ServiceTariff
    {
        public int TariffId { get; set; }
        public int FranchiseRateID { get; set; }
        public int ServiceId { get; set; }
        public long Amount { get; set; }
    }

}
