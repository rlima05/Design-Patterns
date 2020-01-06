using System;

namespace CompositePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var root = new Group("Team");

            root.Add(new Individual("Architect"));

            var developers = new Group("Developers");
            developers.Add(new Individual("Developer1"));
            developers.Add(new Individual("Developer2"));
            developers.Add(new Individual("Developer3"));
            root.Add(developers);

            var testers = new Group("Testers");
            testers.Add(new Individual("Tester1"));
            testers.Add(new Individual("Tester2"));
            root.Add(testers);

            root.Add(new Individual("Scrum Master"));
            root.Add(new Individual("Project Manager"));

            root.Display(1);


            Console.ReadKey();
        }
    }
}
