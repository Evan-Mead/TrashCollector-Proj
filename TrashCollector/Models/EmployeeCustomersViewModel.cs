﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrashCollector.Models
{
    public class EmployeeCustomersViewModel
    {
        public Employee Employee { get; set; }
        public List<Customer> Customers { get; set; }
    }
}
