using DesignPatterns.ModelBuilder;
using DesignPatterns.Models;

namespace DesignPatterns.Infraestructure.Factories
{
    public class FordExplorerFactory : CarFactory
    {
        public override Vehicle Create()
        {
            return new CarBuilder()
                .setModel("Explorer")
                .setColor("Black")
                .Build();
        }
    }
}
