using Invoice.Control.Domain.Commons;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoice.Control.Domain.Entities
{
    public class Revenue : Entity
    {
        public string InvoiceId { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime TransactionDate { get; set; }
        public DateTime BillingDate { get; set; }
        public decimal Amount { get; set; }
        public int CustomerId { get; set; }
        public int UserId { get; set; }
        public Customer Customer { get; set; }
    }
}
