using Invoice.Control.Domain.Commons;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoice.Control.Domain.Entities
{
    public class Customer : Entity
    {
        public string Cnpj { get; set; } = string.Empty;
        public string CommercialName { get; set; } = string.Empty;
        public string LegalName { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;       
        public string Email { get; set; } = string.Empty;       
        public string City { get; set; } = string.Empty;        
        public string State { get; set; } = string.Empty;
        public bool Enabled { get; set; } 
        public ICollection<Revenue> Revenues { get; set; }
        public ICollection<Expense> Expenses { get; set; }
    }
}
