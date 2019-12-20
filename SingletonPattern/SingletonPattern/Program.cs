using System;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstRequest = LoadBalancer.GetLoadBalancer().GetServer();
            var secondequest = LoadBalancer.GetLoadBalancer().GetServer();
            var thirdRequest = LoadBalancer.GetLoadBalancer().GetServer();
            var forthRequest = LoadBalancer.GetLoadBalancer().GetServer();
            var fifthRequest = LoadBalancer.GetLoadBalancer().GetServer();

            if(LoadBalancer.GetLoadBalancer() == LoadBalancer.GetLoadBalancer() && LoadBalancer.GetLoadBalancer() == LoadBalancer.GetLoadBalancer())
                Console.WriteLine("Same");

            Console.WriteLine(firstRequest);
            Console.WriteLine(secondequest);
            Console.WriteLine(thirdRequest);
            Console.WriteLine(forthRequest);
            Console.WriteLine(fifthRequest);

            Console.ReadKey();
        }
    }
}
