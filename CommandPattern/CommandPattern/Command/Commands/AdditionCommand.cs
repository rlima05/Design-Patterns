namespace CommandPattern.Command
{
    public class AdditionCommand : ACommand
    {
        public override int Execute(int a, int b)
        {
            return a + b;
        }
    }
}
