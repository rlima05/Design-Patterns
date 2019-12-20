using System;
using System.Collections.Generic;
using System.Text;

namespace FacadaPattern.SubSystems
{
    public class CodingTest
    {
        public bool ReviewCodingTest(Candidate candidate)
        {
            Console.WriteLine($"Reviewing the coding test of {candidate.Name}");
            return true;
        }
    }
}
