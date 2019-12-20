using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

namespace SingletonPattern
{
    public sealed class LoadBalancer
    {
        private List<string> _servers; 

        private static readonly LoadBalancer _instance  = new LoadBalancer();
        public static LoadBalancer GetLoadBalancer() => _instance;

        private Random _random = new Random();
        private LoadBalancer()
        {
            _servers = new List<string>
            {
                "Server1",
                "Server2",
                "Server3",
                "Server4",
                "Server5",
                "Server6",
                "Server7",
                "Server8",
                "Server9",
                "Server10"
            };
        }

        public string GetServer() => _servers[_random.Next(9)];
    
    }
}
