using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    //All fields and method inside the interface are public, so no need to mention it as public
    //It just a contract, that is the reason there is no code added here except the required fields , only the property and method signatures
    public interface IProductModel
    {
        string Title { get; set; }

        bool HasOrderHasBeenCompleted { get; }

        public void ShipItem(CustomerModel customer);
    }
}
