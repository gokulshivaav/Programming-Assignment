using System;

public class Order
{
    private string orderDetails;
    private int quantity;
    private double bill;
    private int orderNo;

    public Order(int orderNo, string orderDetails, int quantity)
    {
        this.orderNo = orderNo;
        this.orderDetails = orderDetails;
        this.quantity = quantity;
    }

    public int OrderNo { get { return orderNo; } }
    public string OrderDetails { get { return orderDetails; } }
    public int Quantity { get { return quantity; } }

    public double PayBill(double price)
    {
        bill = price * quantity;
        return bill;
    }

    public void DisplayOrder()
    {
        Console.WriteLine($"Order No: {orderNo}, Item: {orderDetails}, Qty: {quantity}, Bill: €{bill}");
    }
}