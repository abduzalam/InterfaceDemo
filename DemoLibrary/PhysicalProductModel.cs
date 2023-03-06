using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class PhysicalProductModel : IProductModel
    {
        public string Title { get; set; }
        public bool HasOrderHasBeenCompleted { get; private set; }

        //use of privae set , the above HasOrderCompleted is same as below declaration
        /* private bool hasOrder;
           public bool HasOrder
           {
               get { return hasOrder; }
           }*/
        public void ShipItem(CustomerModel customer)
        {
            if(HasOrderHasBeenCompleted == false)
            {
                Console.WriteLine($"Simulating Shipping {Title} to {customer.FirstName} in {customer.City}");
                HasOrderHasBeenCompleted = true;
            }
        }
    }
}
