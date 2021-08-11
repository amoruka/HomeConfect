namespace Abstractions.Commands
{
    public interface ICommand<in TContext> where TContext : ICommandContext
    {
        void Execute(TContext context);
    }
}
