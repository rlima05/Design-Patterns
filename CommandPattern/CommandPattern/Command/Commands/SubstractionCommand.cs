namespace CommandPattern.Command
{
    public class SubstractionCommand : ACommand
    {
        public override int Execute(int a, int b)
        {
            return a - b;
        }
    }
}
