using _Game.Scripts.World.Providers;
using FFS.Libraries.StaticEcs.Unity.Editor;
using UnityEditor;

namespace _Game.Scripts.World.Editor
{
[CustomEditor(typeof(GameWorldEventProvider)), CanEditMultipleObjects]
public class GameWorldEventProviderEditor : StaticEcsEvenTEntityProviderEditor<GameWorld, GameWorldEventProvider> { }
}
