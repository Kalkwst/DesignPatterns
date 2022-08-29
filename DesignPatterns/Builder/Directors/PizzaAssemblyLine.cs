using Builder.Builders;

namespace Builder.Directors
{
    /// <summary>
    /// The Director class
    /// </summary>
    public class AssemblyLine
    {
        public void Assemble(PizzaBuilder builder)
        {
            builder.AddDough();
            builder.AddSauce();
            builder.AddCheeses();
            builder.AddMeats();
            builder.AddVeggies();
            builder.AddExtras();
        }
    }
}
