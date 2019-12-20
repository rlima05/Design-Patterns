using System;
using System.Collections.Generic;
using System.Text;

namespace FacadaPattern.SubSystems
{
    public class HiringManager
    {
        public bool InterviewCandidate(Candidate candidate)
        {
            Console.WriteLine($"Interviewing candidate {candidate.Name} for the role {candidate.Role}");
            return true;
        }
    }
}
