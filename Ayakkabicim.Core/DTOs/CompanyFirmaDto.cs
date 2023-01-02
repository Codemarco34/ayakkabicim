using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ayakkabicim.Core.DTOs
{
    public class CompanyFirmaDto : BaseCompanyDto
    {
        public string Name { get; set; }
        public string Adress { get; set; }
        public string PhoneNumber { get; set; }
        public int FaxNumber { get; set; }
        public string WebUrl { get; set; }
        public string TaxAdministration { get; set; }
        public int TaxNumber { get; set; }
        public string EPosta { get; set; }
        public string InvoiceAdress { get; set; }
        public string EInvoice { get; set; }
        public string CompanyType { get; set; }
    }
}
