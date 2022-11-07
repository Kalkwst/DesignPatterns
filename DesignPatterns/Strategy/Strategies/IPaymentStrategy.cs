namespace Strategy.Strategies;

/// <summary>
/// Common interface for all strategies
/// </summary>
public interface IPaymentStrategy
{
    bool Pay(int amount);
    void Authenticate();
}