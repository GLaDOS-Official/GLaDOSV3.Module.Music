using Discord.Commands;
using Discord.WebSocket;
using GLaDOSV3.Helpers;
using System;
using System.Reflection;
using System.Runtime.Loader;
using GLaDOSV3.Models.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace GLaDOSV3.Module.Music
{
    public class ModuleInfo : IGladosModule
    {
        public string Name() => "Music";

        public string Version() => "0.0.0.1";

        public Uri UpdateUrl() => null;

        public string Author() => "BlackOfWorld#8125";

        public Type[] Services(DiscordShardedClient discord, CommandService commands, BotSettingsHelper<string> config, IServiceCollection provider) => new Type[] { typeof(AudioService)};

        private static volatile ModuleInfo _singleton;
        public static IGladosModule GetModule()
        {
            if (_singleton != null) return _singleton;
            _singleton = new ModuleInfo();
            Assembly currentAssembly = Assembly.GetExecutingAssembly();
            AssemblyLoadContext currentContext = AssemblyLoadContext.GetLoadContext(currentAssembly);
            currentContext.Unloading += OnPluginUnloadingRequested;
            return _singleton;
        }

        public void PreLoad(DiscordShardedClient discord, CommandService commands, BotSettingsHelper<string> config, IServiceProvider provider)
        {
        }
        public void PostLoad(DiscordShardedClient discord, CommandService commands, BotSettingsHelper<string> config, IServiceProvider provider)
        {
        }

        public void Reload(DiscordShardedClient discord, CommandService commands, BotSettingsHelper<string> config, IServiceProvider provider)
        { }

        public void Unload(DiscordShardedClient discord, CommandService commands, BotSettingsHelper<string> config, IServiceProvider provider)
        { }

        public static void OnPluginUnloadingRequested(AssemblyLoadContext obj)
        { }
    }
}
