using _Game.Scripts.World.Systems;
using FFS.Libraries.StaticEcs.Unity;
using VContainer;
using VContainer.Unity;

namespace _Game.Scripts.World
{
public class WorldScope : LifetimeScope
{
    protected override void Configure(IContainerBuilder builder)
    {
        W.Create();
        GameSys.Create();
        FixedSys.Create();

        EcsDebug<GameWorld>.AddWorld<WorldSystems>();
        EcsDebug<GameWorld>.AddWorld<FixedSystems>();

        W.Types().RegisterAll();
        W.Initialize();

        GameSys.Add(new RegenerationSystem());
        GameSys.Add(new SpawnerSystem());
        
        GameSys.Initialize();
        FixedSys.Initialize();
        
        builder.RegisterEntryPoint<WorldUpdater>();
    }
}
}
