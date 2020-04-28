using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrashCollector.Models
{
    public class EmployeePickUpTrashModel
    {
        public DateTime PickUpDate { get; set; }
        public int CustomerId { get; set; }
        public int EmployeeId { get; set; }
        public string CompletedPickUpMessage { get; set; }
    }
}
