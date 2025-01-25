using DesignPatterns.ModelBuilder;
using DesignPatterns.Models;

namespace DesignPatterns.Infraestructure.Factories
{
    public class FordMustangFactory : CarFactory
    {
        public override Vehicle Create()
        {
            return new CarBuilder()
                .setModel("Mustang")
                .setColor("Red")
                .Build();
        }
    }
}
