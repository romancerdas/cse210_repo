using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

public class Product
{
    private string _name;
    private int _productid;
    private double _priceperunit;
    private int _quantity;

    public Product(string name, int productid, double priceperunit, int quantity)
    {
        _name = name;
        _productid = productid;
        _priceperunit = priceperunit;
        _quantity = quantity;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetStringProductID()
    {
        string stringproductid = _productid.ToString();
        return stringproductid;
    }

    public double GetTotalPrice()
    {
        return _quantity * _priceperunit;
    }
}