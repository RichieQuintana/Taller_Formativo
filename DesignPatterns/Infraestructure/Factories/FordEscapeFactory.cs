using DesignPatterns.ModelBuilder;
using DesignPatterns.Models;

namespace DesignPatterns.Infraestructure.Factories
{
    public class FordEscapeFactory : CarFactory
    {
        public override Vehicle Create()
        {
            return new CarBuilder()
                .setModel("Escape")
                .setColor("Blue")
                .Build();
        }
    }
}
