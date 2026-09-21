using _Game.Scripts.World.Components;
using _Game.Scripts.World.Entities;
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
        GW.Create();
        GameSys.Create();
        FixedSys.Create();

        EcsDebug<GameWorld>.AddWorld<WorldSystems>();
        EcsDebug<GameWorld>.AddWorld<FixedSystems>();

        GW.Types().RegisterAll();
        GW.Initialize();

        GameSys.Add(new TestSystem());
        
        GameSys.Initialize();
        FixedSys.Initialize();

        GW.NewEntity<CreatureEntity>().Set(new NameComponent {Name = "player"});
        
        builder.RegisterEntryPoint<WorldUpdater>();
    }
}
}
