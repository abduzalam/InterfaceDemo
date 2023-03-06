using DemoLibrary;

public class Program
{
    private static void Main(string[] args)
    {
        List<IProductModel> cart = AddSampleData();
        CustomerModel customer = GetCustomer();

        foreach (IProductModel prod in cart)
        {
            prod.ShipItem(customer);

            if (prod is IDigitalProductModel digital)
            {
                Console.WriteLine($"For the {digital.Title} you have {digital.TotalDownloadsLeft} downloads left.");
            }
        }
        Console.ReadLine();
    }

    private static CustomerModel GetCustomer()
    {
        return new CustomerModel()
        {
            FirstName = "AbdulSalam",
            LastName = "Abd",
            City = "Kochin",
            EmailAddress = "abdul@abc.com",
            PhoneNumber = "555-1212"
        };
    }

    private static List<IProductModel> AddSampleData()
    {
        List<IProductModel> output = new List<IProductModel>();

        output.Add(new PhysicalProductModel() { Title = "Nerf Football" });
        output.Add(new PhysicalProductModel() { Title = "I am Abdul T-Shirt" });
        output.Add(new PhysicalProductModel() { Title = "Hard Drive" });
        output.Add(new DigitalProductModel() { Title = "MS Code Complete" });
        return output;
    }
}