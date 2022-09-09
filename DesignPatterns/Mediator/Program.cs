using Mediator;
using Mediator.Components;

SnackBarMediator mediator = new SnackBarMediator();

HotDogStand leftKitchen = new HotDogStand(mediator);
FrenchFriesStand rightKitchen = new FrenchFriesStand(mediator);

mediator.HotDogStand = leftKitchen;
mediator.FriesStand = rightKitchen;

leftKitchen.Send("Can you send more cooking oil?");
rightKitchen.Send("Sure thing, Homer's on his way");

rightKitchen.Send("Do you have any extra soda? We've had a rush on them over here.");
leftKitchen.Send("Just a couple, we'll send Homer back with them");

Console.ReadKey();
