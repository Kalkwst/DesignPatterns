namespace Mediator.Components
{
    /// <summary>
    /// A Concrete Component class
    /// </summary>
    public class HotDogStand : SnackBar
    {
        public HotDogStand(IMediator mediator) : base(mediator)
        {
        }

        public void Send(string message)
        {
            Console.WriteLine($"HotDog Stand says: {message}");
            _mediator.SendMessage(message, this);
        }

        public void Notify(string message)
        {
            Console.WriteLine($"HotDog Stand gets message: {message}");
        }
    }
}
