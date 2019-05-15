using System;
using System.Linq;
using System.Threading.Tasks;

namespace HelloWorld.Services
{
    public class GreetingService
    {
        public Greeting GetGreeting()
        {
            return new Greeting()
            {
                Salutation = "Hello",
                Audience = "GitHub Satellite",
                Description = "Welcome to the Azure Pipelines booth!"
            };
        }

        public Task<Greeting> GetGreetingAsync()
        {
            return new Task<Greeting>(() => GetGreeting());
        }
    }
}
