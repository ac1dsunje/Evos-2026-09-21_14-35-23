using VContainer.Unity;

namespace _Game.Scripts.World
{
public class WorldUpdater : ITickable, IFixedTickable
{
    public void Tick()
    {   
        GameSys.Update();
    }

    public void FixedTick()
    {
        FixedSys.Update();
    }
}
}