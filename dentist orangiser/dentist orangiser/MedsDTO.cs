using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class MedsDTO
{
    private string name, supplier;
    private int id, price, quantity;

    public string NAME
    {
        get { return name; }
        set { name = value; }
    }
    public string SUPPLIER
    {
        get { return supplier; }
        set { supplier = value; }
    }

    public int ID
    {
        get { return id; }
        set { id = value; }
    }

    public int PRICE
    {
        get { return price; }
        set { price = value; }
    }

    public int QUANTITY
    {
        get { return quantity; }
        set { quantity = value; }
    }

    public MedsDTO(string name, string supplier, int id, int price, int quantity)
    {
        this.name = name;
        this.supplier = supplier;
        this.id = id;
        this.price = price;
        this.quantity = quantity;
    }
}