using FFS.Libraries.StaticEcs;

namespace _Game.Scripts.World
{
public struct GameWorld : IWorldType { }
public abstract class W : World<GameWorld> { }
}