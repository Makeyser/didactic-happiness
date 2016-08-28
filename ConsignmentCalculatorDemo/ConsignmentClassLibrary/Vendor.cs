using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsignmentClassLibrary
{
    public class Vendor
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public double commission { get; set; }
        public decimal paymentDue { get; set; }

        public string Display
        {
            get
            {
                return string.Format("{0} {1} - {2}", firstName, lastName, paymentDue.ToString("c"));
            }

        }

        public Vendor()
        {
            commission = .5;
        }
    }
}
