using System;
using System.Collections.Generic;
using System.Text;

namespace Banking.Core
{
    public class CustomerAccount
    {
        public int CustomerAccountId { get; set; }
        public decimal Balance { get; set; }

        public Customer Customer { get; set; }
    }
}
