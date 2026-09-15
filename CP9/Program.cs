using CP9;

var orders = new List<string>
{
    "ORDER001;150.50;3",
    "плохая строка",
    "ORDER002;-10;1",
    "ORDER003;200;2"
};

var processor = new OrderProcessor();
processor.ProcessOrders(orders);
