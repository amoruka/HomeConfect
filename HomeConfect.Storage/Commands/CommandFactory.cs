using Abstractions.Commands;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace HomeConfect.Storage.Commands
{
    public class CommandFactory : ICommandFactory
    {
        private readonly IServiceProvider serviceProvider;

        private Dictionary<Type, Type> Commands;

        public CommandFactory(IServiceProvider provider)
        {
            serviceProvider = provider;

            LoadCommands();
        }

        public ICommand<TCommandContext> Create<TCommandContext>() where TCommandContext : ICommandContext
        {
            var incomingContext = typeof(TCommandContext);

            var type = Commands[incomingContext];

            // Service locator?
            return Activator.CreateInstance(type, serviceProvider.GetService(typeof(Context))) as ICommand<TCommandContext>;
        }

        private void LoadCommands()
        {
            Commands = new Dictionary<Type, Type>();

            var commandTypes = Assembly.GetExecutingAssembly().GetTypes().Where(x => !x.IsAbstract && x.GetInterface(typeof(ICommand<ICommandContext>).Name) != null).ToList();

            foreach (var commandType in commandTypes)
            {
                var iType = commandType.GetInterface(typeof(ICommand<ICommandContext>).Name);

                var genericArgs = iType.GetGenericArguments();

                if (genericArgs.Count() == 1)
                {
                    Commands.Add(genericArgs[0], commandType);
                }
            }
        }
    }
}
