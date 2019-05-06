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
                Audience = "Microsoft Build",
                Description = "Welcome to the Azure DevOps booth!"
            };
        }

        public Task<Greeting> GetGreetingAsync()
        {
            return new Task<Greeting>(() => GetGreeting());
        }
    }
}
