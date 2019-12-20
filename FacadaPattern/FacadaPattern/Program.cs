using System;

namespace FacadaPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var candidate = new Candidate
            {
                Name = "Raphael",
                Role = ".NET Developer"
            };

            var hiringProcess = new HiringProcess();

            hiringProcess.DoHiringProcess(candidate);

            Console.ReadKey();
        }
    }
}
