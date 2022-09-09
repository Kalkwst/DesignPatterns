using Mediator.Components;

namespace Mediator
{
    /// <summary>
    /// The Concrete Mediator class, which implements the send message
    /// method and keep track of all participants in the conversation.
    /// </summary>
    public class SnackBarMediator : IMediator
    {
        private HotDogStand hotDogStand;
        private FrenchFriesStand friesStand;

        public HotDogStand HotDogStand { set { hotDogStand = value; } }
        public FrenchFriesStand FriesStand { set { friesStand = value; } }

        public void SendMessage(string message, SnackBar snackBar)
        {
            if (snackBar == hotDogStand)
                friesStand.Notify(message);
            if (snackBar == friesStand)
                hotDogStand.Notify(message);
        }
    }
}
