using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace TrashCollector.Models
{
    public class EmployeeCustomersViewModel
    {
        public Employee Employee { get; set; }
        public List<Customer> Customers { get; set; }
        public string SelectedDay { get; set; }
        public SelectList DaysToSelect { get; set; }
    }
}
