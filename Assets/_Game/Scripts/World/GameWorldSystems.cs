using FFS.Libraries.StaticEcs;

namespace _Game.Scripts.World
{
public struct WorldSystems : ISystemsType { }
public struct FixedSystems : ISystemsType { }
public abstract class GameSys : W.Systems<WorldSystems> { }
public abstract class FixedSys : W.Systems<FixedSystems> { }
}