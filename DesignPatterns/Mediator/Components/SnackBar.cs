namespace Mediator.Components
{
    /// <summary>
    /// The SnackBar abstract class, representing an
    /// entity involved in the conversation which 
    /// should receive messages.
    /// </summary>
    public class SnackBar
    {
        protected IMediator _mediator;

        public SnackBar(IMediator mediator)
        {
            _mediator = mediator;
        }
    }
}
