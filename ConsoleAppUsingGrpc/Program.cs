using System;
using Helloworld;
using Grpc.Core;

namespace ConsoleAppUsingGrpc
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = new HelloRequest { Name = "world" };
            Console.WriteLine($"Hello {x.Name} using Grpc!");

            try
            {
                // This will probably fail. But it doesn't matter.
                // We just need to keep a reference to Grpc.
                Channel channel = new Channel("127.0.0.1:50051", ChannelCredentials.Insecure);
                var client = new Greeter.GreeterClient(channel);
            }
            catch (Exception)
            {

            }
        }
    }
}
