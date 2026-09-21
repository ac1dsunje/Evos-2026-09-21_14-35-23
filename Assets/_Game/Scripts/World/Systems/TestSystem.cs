using _Game.Scripts.World.Components;
using FFS.Libraries.StaticEcs;
using UnityEngine;

namespace _Game.Scripts.World.Systems
{
public struct TestSystem : ISystem
{
    public void Update()
    {
        foreach (var entity in GW.Query<All<NameComponent>>().Entities())
        {
            ref readonly var name = ref entity.Read<NameComponent>();
            
            Debug.Log(name.Name);
        }
    }
}
}