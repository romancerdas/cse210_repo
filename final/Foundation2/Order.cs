using System.Dynamic;
using System.Security.Cryptography.X509Certificates;

public class Order
{
    private Customer _customer;
    List<Product> _ListOfProducts = new List<Product>();
    private string _shippinglabel;
    private string _packinglabel;

    public Order(Customer customer, List<Product> listofproducts)
    {
        _customer = customer;
        _ListOfProducts = listofproducts;
        // _shippinglabel = CreateShippingLabel();
        // _packinglabel = CreatePackingLabel();
    }

    public string CreateShippingLabel()
    {
        return $"Shipping Label: \n{_customer.GetName()} \n{_customer.GetAddress().DisplayFullAddress()}";
    }

    public string CreatePackingLabel()
    {
        string label = "";

        foreach (Product product in _ListOfProducts)
        {
            label += $"{product.GetName()} : {product.GetStringProductID()} \n";
        }

        return $"Packing Label: \n{label}";
    }



    public int GetShippingCost()
    {
        Address address = _customer.GetAddress();
        if (address.InUS() == true)
        {
            return 5;
        }
        else
        {
            return 35;
        }
    }
    public double GetTotalPrice()
    {
        double subtotal = 0;

        foreach (Product product in _ListOfProducts)
        {
            subtotal += product.GetTotalPrice();
        }

        double total = subtotal + GetShippingCost();

        return total;
    }
}