using Discord.Commands;
using Discord.WebSocket;
using GLaDOSV3.Helpers;
using GLaDOSV3.Models;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace GLaDOSV3.Module.Music
{
    public class ModuleInfo : GladosModule
    {
        public override string Name => "Music";

        public override string Version => "0.0.0.1";

        public override string AuthorLink => "https://github.com/BlackOfWorld";

        public override Type[] Services(DiscordShardedClient discord, CommandService commands, BotSettingsHelper<string> config, IServiceCollection provider) => new Type[] { typeof(AudioService) };

    }
}
