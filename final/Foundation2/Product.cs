using System;

class Product
{
    private string _pname;
    private int _id;
    private decimal _priceperunit;
    private int _quantity;

    public Product(string pname, int id, decimal priceperunit, int quantity)
    {
        _pname = pname;
        _id = id;
        _priceperunit = priceperunit;
        _quantity = quantity;
        
    }

    public decimal GetTotalCost()
    {
        return _priceperunit * _quantity;
    }

    public string GetPname()
    {
        return _pname;
    }

    public int GetId()
    {
        return _id;
    }
}

