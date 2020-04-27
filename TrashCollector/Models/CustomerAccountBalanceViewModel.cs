using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrashCollector.Models
{
    public class CustomerAccountBalanceViewModel
    {
        public Customer Customer { get; set; }
        public double AccountBalance { get; }
    }
}
