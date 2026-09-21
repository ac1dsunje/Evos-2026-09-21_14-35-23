using _Game.Scripts.World;
using _Game.Scripts.World.Providers;
using FFS.Libraries.StaticEcs.Unity.Editor;
using UnityEditor;

namespace _Game.Editor
{
public class GameWorldEcsView : StaticEcsView<GameWorld, GameWorldEntityProvider, GameWorldEventProvider> {
    [MenuItem("Window/GameWorld ECS")]
    public static void OpenWindow() {
        var window = GetWindow<GameWorldEcsView>();
        window.Show();
        window.Focus();
    }
}
}
