using _Game.Scripts.World.Components;
using FFS.Libraries.StaticEcs;

namespace _Game.Scripts.World.Systems
{
public struct RigidBodyMoverSystem : ISystem
{
    public void Update()
    {
        foreach (var entity in W.Query<All<RigidBodyComponent, InputComponent>>().Entities())
        {
            ref var body = ref entity.Ref<RigidBodyComponent>();
            ref readonly var input = ref entity.Read<InputComponent>();
            
            body.Body.linearVelocity = input.Direction;
        }
    }
}
}