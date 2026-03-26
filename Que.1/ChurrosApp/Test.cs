using System;

public class Test
{
    public static void TestPayBill()
    {
        Console.WriteLine("\nRunning Unit Test...");

        Order testOrder = new Order(1, "Test Item", 2);
        double result = testOrder.PayBill(6);

        if (result == 12)
        {
            Console.WriteLine("Test Passed ✅");
        }
        else
        {
            Console.WriteLine("Test Failed ❌");
        }
    }
}