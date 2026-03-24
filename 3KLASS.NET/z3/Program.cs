using System;
using System.Collections.Generic;

abstract class Order
{
    public int OrderId { get; set; }
    public string CustomerName { get; set; }
    public decimal TotalAmount { get; set; }

    public Order(int orderId, string customerName, decimal totalAmount)
    {
        OrderId = orderId;
        CustomerName = customerName;
        TotalAmount = totalAmount;
    }

    public override string ToString()
    {
        return $"Заказ #{OrderId}, {CustomerName}, сумма: {TotalAmount:C}";
    }
}

sealed class OnlineOrder : Order
{
    public string DeliveryAddress { get; set; }

    public OnlineOrder(int orderId, string customerName, decimal totalAmount, string deliveryAddress)
        : base(orderId, customerName, totalAmount)
    {
        DeliveryAddress = deliveryAddress;
    }

    public override string ToString()
    {
        return base.ToString() + $", адрес доставки: {DeliveryAddress}";
    }
}

sealed class InStoreOrder : Order
{
    public string PickupPoint { get; set; }

    public InStoreOrder(int orderId, string customerName, decimal totalAmount, string pickupPoint)
        : base(orderId, customerName, totalAmount)
    {
        PickupPoint = pickupPoint;
    }

    public override string ToString()
    {
        return base.ToString() + $", пункт выдачи: {PickupPoint}";
    }
}

class Store
{
    private Order[] orders;

    public Store(Order[] orders)
    {
        this.orders = orders;
    }

    public Order GetLargestOrder()
    {
        if (orders == null || orders.Length == 0)
            return null;

        Order largest = orders[0];
        for (int i = 1; i < orders.Length; i++)
        {
            if (orders[i].TotalAmount > largest.TotalAmount)
            {
                largest = orders[i];
            }
        }
        return largest;
    }

    public List<Order> GetOrdersByCustomer(string customerName)
    {
        List<Order> result = new List<Order>();
        foreach (var order in orders)
        {
            if (order.CustomerName.Equals(customerName, StringComparison.OrdinalIgnoreCase))
            {
                result.Add(order);
            }
        }
        return result;
    }

    public void DisplayAllOrders()
    {
        foreach (var order in orders)
        {
            Console.WriteLine(order);
        }
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Введите количество заказов: ");
        int n = int.Parse(Console.ReadLine());

        Order[] orders = new Order[n];

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"\nЗаказ {i + 1}:");
            Console.Write("Введите ID заказа: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Введите имя клиента: ");
            string name = Console.ReadLine();
            Console.Write("Введите сумму заказа: ");
            decimal amount = decimal.Parse(Console.ReadLine());
            Console.Write("Тип заказа (1 - онлайн, 2 - в магазине): ");
            int type = int.Parse(Console.ReadLine());

            if (type == 1)
            {
                Console.Write("Введите адрес доставки: ");
                string address = Console.ReadLine();
                orders[i] = new OnlineOrder(id, name, amount, address);
            }
            else
            {
                Console.Write("Введите пункт выдачи: ");
                string pickup = Console.ReadLine();
                orders[i] = new InStoreOrder(id, name, amount, pickup);
            }
        }

        Store store = new Store(orders);

        Console.WriteLine("\nВсе заказы:");
        store.DisplayAllOrders();

        Console.WriteLine("\nСамый большой заказ:");
        Order largest = store.GetLargestOrder();
        Console.WriteLine(largest);

        Console.Write("\nВведите имя клиента для поиска его заказов: ");
        string searchName = Console.ReadLine();

        List<Order> customerOrders = store.GetOrdersByCustomer(searchName);
        Console.WriteLine($"\nЗаказы клиента '{searchName}':");
        foreach (var order in customerOrders)
        {
            Console.WriteLine(order);
        }

        Console.ReadKey();
    }
}
