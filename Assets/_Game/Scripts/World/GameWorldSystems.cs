using FFS.Libraries.StaticEcs;

namespace _Game.Scripts.World
{
public struct WorldSystems : ISystemsType { }
public struct FixedSystems : ISystemsType { }
public abstract class GameSys : GW.Systems<WorldSystems> { }
public abstract class FixedSys : GW.Systems<FixedSystems> { }
}