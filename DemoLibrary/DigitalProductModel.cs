using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class DigitalProductModel : IDigitalProductModel
    {
        public string? Title { get; set; }

        public bool HasOrderHasBeenCompleted { get; private set; }

        public int TotalDownloadsLeft { get; private set; } = 5;
        //Here we usually email the digital product to the Customer, so HasOrderBeenCompleted is not required here
        public void ShipItem(CustomerModel customer)
        {
           
            if (HasOrderHasBeenCompleted == false)
            {
                Console.WriteLine($"Simulating emailing {Title} to {customer.EmailAddress}");
                TotalDownloadsLeft -= 1;
                if (TotalDownloadsLeft < 1 )
                {
                    HasOrderHasBeenCompleted = true;
                    TotalDownloadsLeft = 0;
                }

            }
        }
    }
}
