using JCMG.EntitasRedux;

namespace Ecs.Game.Components
{
    [Game]
    [Event(EventTarget.Self)]
    public class MoodComponent : IComponent
    {
        public float Value;
    }
}