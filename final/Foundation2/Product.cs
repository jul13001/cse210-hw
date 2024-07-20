using System;

public class Product
{
    private string _productName;
    private double _price;
    private int _quantity;
    private string _productId;

    public Product(string productName, float price, int quantity, string productId)
    {
        _productName = productName;
        _price = price;
        _quantity = quantity;
        _productId = productId;

    }
    public string productName { get { return _productName; } }
    public string productId { get { return _productId; } }
    public double price { get { return _price; } }

    public double GetTotalCost()
    {
        return _price * _quantity;
    }
}
