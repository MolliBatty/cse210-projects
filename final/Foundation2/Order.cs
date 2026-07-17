using System;
using System.Collections.Generic;

class Order
{
    private Customer _customer;
    private List<Product> _products;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);

    }

    public decimal GetTotalCost()
    {
        decimal total = 0;
        foreach (Product p in _products)
        {
            total = total + p.GetTotalCost();
        }

        decimal shipping;
        if (_customer.IsInUSA())
        {
            shipping = 5;
        }
        else
        {
            shipping = 35;
        }
        return total + shipping;
    }

    public string GetPackingLabel()
    {
        string label = "";
        foreach (Product p in _products)
        {
            label += $"{p.GetPname()} - {p.GetId()}\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        return $"{_customer.GetCname()}\n{_customer.GetAddress().GetFullAddress()}";
    }

}