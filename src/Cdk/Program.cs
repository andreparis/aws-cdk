using Amazon.CDK;
using Infrastructure.Stacks;

namespace Cdk
{
    sealed class Program
    {
        public static void Main(string[] args)
        {
            var app = new App();

            var props = new StackProps()
            {
                Env = new Environment()
                {
                    Account = "277944362602",
                    Region = "us-east-1"
                }
            };

            var network = new NetworkStack(app, "player2", props);

            new FrontendStack(app, "player2", "player2.store");

            app.Synth();
        }
    }
}
