using _Game.Scripts.World.Providers;
using FFS.Libraries.StaticEcs.Unity.Editor;
using UnityEditor;

namespace _Game.Scripts.World.Editor
{
[CustomEditor(typeof(GameWorldEntityProvider)), CanEditMultipleObjects]
public class GameWorldEntityProviderEditor : StaticEcsEntityProviderEditor<GameWorld, GameWorldEntityProvider> { }
}
