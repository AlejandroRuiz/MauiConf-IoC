using System;
using DIDemo.Configuration;
using Microsoft.Extensions.Configuration;

namespace DIDemo.Extensions;

public static class ConfigurationBuilderExtensions
{
    public static IConfigurationBuilder AddPreferences(this IConfigurationBuilder builder, IEnumerable<string> availableKeys)
    {
        builder.Add(new ConfigurationSource(availableKeys));

        return builder;
    }
}

