using FacadaPattern.SubSystems;
using System;
using System.Collections.Generic;
using System.Text;

namespace FacadaPattern
{
    //This is the facade
    public class HiringProcess
    {
        private readonly TalentAcquisition _talentAcquisition = new TalentAcquisition();
        private readonly CodingTest _codingTest = new CodingTest();
        private readonly HiringManager _hiringManager = new HiringManager();

        public void DoHiringProcess(Candidate candidate)
        {
            var cvApproved = _talentAcquisition.ApproveCV(candidate);
            var codingTestApproved = _codingTest.ReviewCodingTest(candidate);
            var hiringApproved = _hiringManager.InterviewCandidate(candidate);

            candidate.Hired = cvApproved && codingTestApproved && hiringApproved;

            Console.WriteLine($"Candidate {candidate.Name} has been {GetHiredText(candidate.Hired)} for the role {candidate.Role}");
        }

        private string GetHiredText(bool hired)
        {
            return hired ? "hired" : "not hired";
        }
    }
}
