#region

using Dalamud.Plugin;
using WrathCombo.API.IPC.RawMethods;

#endregion

namespace WrathCombo.API;

public static partial class WrathIPCWrapper
{
    private static bool _isInitialized;

    public static void InitWrapper(IDalamudPluginInterface pluginInterface)
    {
        pluginInterface.Create<RawMethod>();
        _isInitialized = true;
    }
}