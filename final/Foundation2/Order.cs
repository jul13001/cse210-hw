using System;
using System.Net.Http.Headers;

public class Order
{
    private List<Product> _product;
    private Customer _customer;

    public Order (Customer customer)
    {
        _customer = customer;
        _product = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _product.Add(product);
    }

    public double GetTotalPrice()
    {
        double totalPrice = 0;
        foreach ( var product in _product)
        {
            totalPrice += product.GetTotalCost();
        }

        float shippingCost = 0;
        if (_customer.IsUsa() == true)
        {
            shippingCost = 5;
            return totalPrice + shippingCost;
        }
        else
        {
            shippingCost = 35;
            return totalPrice + shippingCost;
        }
    }
    public string GetPackingLabel()
    {
        string packingLabel = "Packing Label: \n";
        foreach(var product in _product)
        {
            packingLabel += $"Product Name: {product.productName}, Product ID: {product.productId}\n";
        }
        return packingLabel;
    }
    public string GetShippingLabel()
    {
        var address = _customer.Address;
        return $"Shipping Label: \nCustomer Name: {_customer.customerName} \nAddress: {address.streetAddress}, {address.city}, {address.state}, {address.country}";
    }

}