using System;

class Product
{
    public int ProductCode { get; set; }
    public string ProductName { get; set; }
    public double Price { get; set; }
    public int Quantity { get; set; }

    public double BillAmount
    {
        get { return Price * Quantity; }
    }

    public void DisplayBill()
    {
        Console.WriteLine("Product Code: " + ProductCode);
        Console.WriteLine("Product Name: " + ProductName);
        Console.WriteLine("Bill Amount: " + BillAmount);
    }
}

class T3_13
{
    static void Main()
    {
        Product p = new Product();
        p.ProductCode = 1;
        p.ProductName = "Mouse";
        p.Price = 500;
        p.Quantity = 2;

        p.DisplayBill();
    }
}