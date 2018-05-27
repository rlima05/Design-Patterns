namespace CommandPattern.Command
{
    public class DivisionCommand : ACommand
    {
        public override int Execute(int a, int b)
        {
            return a / b;
        }
    }
}
