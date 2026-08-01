using System;
using System.Collections.Generic;
using System.Text;

public class Order
{
    private const double USA_SHIPPING_COST = 5.0;
    private const double INTERNATIONAL_SHIPPING_COST = 35.0;

    private List<Product> _products;
    private Customer _customer;

    public Order(List<Product> products, Customer customer)
    {
        _products = products;
        _customer = customer;
    }

    public List<Product> Products
    {
        get { return _products; }
        set { _products = value; }
    }

    public Customer Customer
    {
        get { return _customer; }
        set { _customer = value; }
    }

    public double GetTotalPrice()
    {
        double total = 0;

        foreach (Product product in _products)
        {
            total += product.GetTotalCost();
        }

        total += _customer.LivesInUSA() ? USA_SHIPPING_COST : INTERNATIONAL_SHIPPING_COST;

        return total;
    }

    public string GetPackingLabel()
    {
        StringBuilder sb = new StringBuilder();

        foreach (Product product in _products)
        {
            sb.AppendLine($"{product.Name} (Product ID: {product.ProductId})");
        }

        return sb.ToString().TrimEnd('\n', '\r');
    }

    public string GetShippingLabel()
    {
        return $"{_customer.Name}\n{_customer.Address.GetFullAddressString()}";
    }
}
