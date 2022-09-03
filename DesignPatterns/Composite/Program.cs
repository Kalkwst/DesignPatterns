using Composite.Composites;
using Composite.Leaves;

var newkaCola = new NewkaCola(0);
newkaCola.Flavors.Add(new NukaCola(150));
newkaCola.Flavors.Add(new NukaCherry(150));

var nukaBerry = new NukaBerry(0);
nukaBerry.Flavors.Add(new NukaCola(150));
nukaBerry.Flavors.Add(new NukaCherry(150));
nukaBerry.Flavors.Add(new NukaGrape(100));

var nukaFancy = new NukaFancy(0);
nukaFancy.Flavors.Add(new NukaWild(50));
nukaFancy.Flavors.Add(new NukaCherry(150));

newkaCola.DisplayHitPoints();
Console.WriteLine("--------------------------");

nukaBerry.DisplayHitPoints();
Console.WriteLine("--------------------------");

nukaFancy.DisplayHitPoints();

