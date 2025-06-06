using Robust.Shared.GameStates;
using System;
using Robust.Shared.Audio;
using Robust.Shared.Serialization;

namespace Content.Shared._Goobstation.HoloCigar;

/// <summary>
/// This is used for...
/// </summary>
[RegisterComponent, NetworkedComponent]
public sealed partial class HoloCigarComponent : Component
{
    [ViewVariables]
    public bool Lit;

    [ViewVariables]
    public SoundSpecifier Music = new SoundPathSpecifier("/Audio/_Goobstation/Items/TheManWhoSoldTheWorld/invisible.ogg");

    [ViewVariables]
    public EntityUid? MusicEntity;

}

[Serializable, NetSerializable]
public sealed class HoloCigarComponentState: ComponentState
{
    public bool Lit;
    public HoloCigarComponentState(bool lit)
    {
        Lit = lit;
    }
}
