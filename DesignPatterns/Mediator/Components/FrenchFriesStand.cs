namespace Mediator.Components
{
    /// <summary>
    /// A Concrete Component class
    /// </summary>
    public class FrenchFriesStand : SnackBar
    {
        public FrenchFriesStand(IMediator mediator) : base(mediator)
        {
        }

        public void Send(string message)
        {
            Console.WriteLine($"French Fries Stand says: {message}");
            _mediator.SendMessage(message, this);
        }

        public void Notify(string message)
        {
            Console.WriteLine($"French Fries Stand gets message: {message}");
        }
    }
}
