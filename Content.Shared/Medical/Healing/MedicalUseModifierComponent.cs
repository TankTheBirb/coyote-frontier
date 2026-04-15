using System.Collections.Generic;
using Content.Shared.Inventory;
using Robust.Shared.GameStates;

namespace Content.Shared.Medical.Healing;

/// <summary>
/// Checks a component on an item for what to multiply the healing rate by.
/// </summary>
[RegisterComponent, NetworkedComponent]
public sealed partial class GloveHealTimeComponent : Component, IClothingSlots
{
    /// <remarks>
    /// The modifier to reduce the healing time by based off the item equipped. Multiplicative with Delay.
    /// </remarks>
    [ViewVariables(VVAccess.ReadWrite)]
    [DataField("medicalUseModifer")]
    public float GloveHealTimeModifer = medicalUseModifier;

    /// <summary>
    /// Only activates MedicalUseModifer if the item is in the correct slot
    /// i.e. having gloves in your pocket doesn't help you, it has to be on your hands
    /// </summary>
    [DataField]
    public SlotFlags Slots { get; set; } = SlotFlags.GLOVES;
}
