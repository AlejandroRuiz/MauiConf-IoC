using DIDemo.Logging;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Logging;

namespace DIDemo.Extensions;

public static class LoggingBuilderExtensions
{
    public static ILoggingBuilder AddCustomLogging(this ILoggingBuilder builder)
    {
        builder.Services.TryAddEnumerable(ServiceDescriptor.Singleton<ILoggerProvider, CustomLoggerProvider>());

        return builder;
    }
}
