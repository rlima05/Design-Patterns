namespace CommandPattern.Command
{
    public class MultiplicationCommand : ACommand
    {
        public override int Execute(int a, int b)
        {
            return a * b;
        }
    }
}
