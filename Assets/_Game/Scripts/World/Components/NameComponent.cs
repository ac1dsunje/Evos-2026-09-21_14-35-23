using FFS.Libraries.StaticEcs;
using FFS.Libraries.StaticEcs.Unity;

namespace _Game.Scripts.World.Components
{
public struct NameComponent : IComponent
{
    [StaticEcsEditorTableValue] public string Name;
}
}