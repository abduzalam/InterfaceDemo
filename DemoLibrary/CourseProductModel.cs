using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class CourseProductModel : IProductModel
    {
        public string? Title { get; set ; }

        public bool HasOrderHasBeenCompleted { get; private set; }

        public void ShipItem(CustomerModel customer)
        {
            if (HasOrderHasBeenCompleted == false)
            {
                Console.WriteLine($"Added the {Title} course to {customer.FirstName}'s account");
                HasOrderHasBeenCompleted = true;
            }
        }
    }
}
