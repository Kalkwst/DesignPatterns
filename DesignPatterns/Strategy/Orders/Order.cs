using Strategy.Strategies;

namespace Strategy.Orders;

/// <summary>
/// Order class. Doesn't know the concrete payment method (strategy) user has
/// picked. It uses common strategy interface to delegate collecting payment data
/// to strategy object. It can be used to save order to database.
/// </summary>
public class Order
{
    private int _totalCost = 0;
    private bool _isClosed = false;

    public void ProcessOrder(IPaymentStrategy strategy)
    {
        strategy.Authenticate();
    }

    public void AddCost(int cost)
    {
        _totalCost += cost;
    }

    public int TotalCost => _totalCost;

    public void Close() => _isClosed = true;

    public bool IsClosed() => _isClosed;
}