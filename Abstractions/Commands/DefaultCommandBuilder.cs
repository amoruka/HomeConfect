namespace Abstractions.Commands
{
    public class DefaultCommandBuilder : ICommandBuilder
    {
        private readonly ICommandFactory commandFactory;

        public DefaultCommandBuilder(ICommandFactory factory)
        {
            commandFactory = factory;
        }

        public void Execute<TCommandContext>(TCommandContext context) where TCommandContext : ICommandContext
        {
            commandFactory.Create<TCommandContext>().Execute(context);
        }
    }
}
