using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using TAB.Data.Enums;

namespace TAB.Data.Entities
{
    public class Transaction
    {
        public int TransactionId { set; get; }
        public DateTime TransactionDate { set; get; }
        public string ExternalTransactionId { set; get; }
        public decimal Amount { set; get; }
        public decimal Fee { set; get; }
        public string Result { set; get; }
        public string Message { set; get; }
        public Status Status { set; get; }
        public string Provider { set; get; }

        public Guid UserId { get; set; }

        public User User { get; set; }

    }
}