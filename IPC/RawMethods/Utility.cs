#region

using Dalamud.Plugin.Ipc;

// ReSharper disable RedundantSuppressNullableWarningExpression
// ReSharper disable StaticMemberInitializerReferesToMemberBelow

#endregion

namespace WrathCombo.API.IPC.RawMethods;

public partial class RawMethod
{
    public static readonly
        ICallGateSubscriber<float?, bool>
        CanWeave =
            Interface!.GetIpcSubscriber<float?, bool>
                ($"{WC}CanWeave");

    public static readonly
        ICallGateSubscriber<float?, float?, bool>
        CanDelayedWeave =
            Interface!.GetIpcSubscriber<float?, float?, bool>
                ($"{WC}CanDelayedWeave");

    public static readonly
        ICallGateSubscriber<uint, bool?, bool?, bool>
        ActionReady =
            Interface!.GetIpcSubscriber<uint, bool?, bool?, bool>
                ($"{WC}ActionReady");
}