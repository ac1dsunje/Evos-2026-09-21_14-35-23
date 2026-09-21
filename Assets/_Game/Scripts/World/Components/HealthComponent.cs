using FFS.Libraries.StaticEcs;
using FFS.Libraries.StaticEcs.Unity;

namespace _Game.Scripts.World.Components
{
public struct HealthComponent : IComponent
{
    [StaticEcsEditorTableValue] public float Value;
}
}