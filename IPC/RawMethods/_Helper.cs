#region

using Dalamud.IoC;
using Dalamud.Plugin;
using JetBrains.Annotations;

#endregion

namespace WrathCombo.API.IPC.RawMethods;

public partial class RawMethod
{
    private const string WC = "WrathCombo.";

    [PluginService]
    private static IDalamudPluginInterface Interface { get; [UsedImplicitly] set; }
        = null!;
}