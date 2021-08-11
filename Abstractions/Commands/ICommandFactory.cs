﻿namespace Abstractions.Commands
{
    public interface ICommandFactory
    {
        ICommand<TCommandContext> Create<TCommandContext>() where TCommandContext : ICommandContext;
    }
}
