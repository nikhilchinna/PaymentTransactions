using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceTransaction.Infrastructure
{
    namespace FinanceTransaction.Core.DTOs
    {
        public class TransactionDto
        {
            public Guid Id { get; set; }  // Optional: could be generated in backend
            public decimal Amount { get; set; }
            public string Description { get; set; }
            public DateTime TransactionDate { get; set; }
            public string Type { get; set; } // e.g., "Credit" or "Debit"
        }
    }

}
