using _Game.Scripts.World;
using _Game.Scripts.World.Providers;
using FFS.Libraries.StaticEcs.Unity.Editor;
using UnityEditor;

namespace _Game.Editor
{
[CustomEditor(typeof(GameWorldEntityProvider)), CanEditMultipleObjects]
public class GameWorldEntityProviderEditor : StaticEcsEntityProviderEditor<GameWorld, GameWorldEntityProvider> { }
}
