using DesignPatterns.Models;

namespace DesignPatterns.Infraestructure.Factories
{
    public abstract class CarFactory
    {
        public abstract Vehicle Create();
    }
}
