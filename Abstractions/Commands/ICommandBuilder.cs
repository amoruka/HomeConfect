namespace Abstractions.Commands
{
    public interface ICommandBuilder
    {
        void Execute<TCommandContext>(TCommandContext context) where TCommandContext : ICommandContext;
    }
}
