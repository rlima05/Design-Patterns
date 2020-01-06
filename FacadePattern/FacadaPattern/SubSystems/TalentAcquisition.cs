using System;
using System.Collections.Generic;
using System.Text;

namespace FacadaPattern.SubSystems
{
    public class TalentAcquisition
    {
        public bool ApproveCV(Candidate candidate)
        {
            Console.WriteLine($"Checking {candidate.Name} CV");
            return true;
        }
    }
}
