using Dalamud.Data;
using Dalamud.Game;
using Dalamud.Game.ClientState;
using Dalamud.Game.ClientState.Conditions;
using Dalamud.Game.ClientState.Keys;
using Dalamud.Game.ClientState.Objects;
using Dalamud.Game.ClientState.Party;
using Dalamud.Game.Command;
using Dalamud.Game.Gui;
using Dalamud.IoC;
using Dalamud.Plugin;
using Dalamud.Plugin.Services;
using PiPiPlugin.PluginModule;
using PixelPerfectEx.IPC;
using System.Collections.Concurrent;
using System.Security;

namespace PixelPerfectEx
{
    internal class Service
    {
        /// <summary>
        /// Gets or sets the plugin itself.
        /// </summary>
        internal static Plugin Plugin { get; set; } = null!;

        /// <summary>
        /// Gets or sets the plugin configuration.
        /// </summary>
        internal static Configuration Configuration { get; set; } = null!;

        /// <summary>
        /// Gets or sets the plugin address resolver.
        /// </summary>
        internal static PluginAddressResolver Address { get; set; } = null!;

        /// <summary>
        /// Gets the Dalamud plugin interface.
        /// </summary>
        [PluginService]
        internal static DalamudPluginInterface Interface { get; private set; } = null!;

        /// <summary>
        /// Gets the Dalamud chat gui.
        /// </summary>
        [PluginService]
        internal static IChatGui ChatGui { get; private set; } = null!;

        /// <summary>
        /// Gets the Dalamud client state.
        /// </summary>
        [PluginService]
        internal static IClientState ClientState { get; private set; } = null!;

        /// <summary>
        /// Gets the Dalamud client Condition.
        /// </summary>
        [PluginService]
        internal static ICondition Condition { get; private set; } = null!;


        /// <summary>
        /// Gets the FF Game Objects.
        /// </summary>
        [PluginService]
        internal static IObjectTable GameObjects { get; private set; } = null!;

        /// <summary>
        /// Gets the Dalamud command manager.
        /// </summary>
        [PluginService]
        internal static ICommandManager CommandManager { get; private set; } = null!;

        /// <summary>
        /// Gets the Dalamud data manager.
        /// </summary>
        [PluginService]
        internal static IDataManager DataManager { get; private set; } = null!;

        /// <summary>
        /// Gets the Dalamud framework.
        /// </summary>
        [PluginService]
        internal static IFramework Framework { get; private set; } = null!;

        /// <summary>
        /// Gets the Dalamud game gui.
        /// </summary>
        [PluginService]
        internal static IGameGui GameGui { get; private set; } = null!;

        /// <summary>
        /// Gets the Dalamud signature scanner.
        /// </summary>
        [PluginService]
        internal static ISigScanner Scanner { get; private set; } = null!;

        [PluginService]
        internal static IPartyList PartieList { get; private set; } = null!;
        [PluginService]
        internal static IGameNetwork GameNetwork { get; private set; } = null!;
        [PluginService]
        internal static IKeyState KeyState { get; private set; } = null!;
        [PluginService]
        internal static IGameInteropProvider GameHook { get; private set; } = null!;

        internal static LogSender LogSender { get; private set; } = new();

        internal static HashSet<Drawing.IDrawData> DrawDatas = new();
    }
}
