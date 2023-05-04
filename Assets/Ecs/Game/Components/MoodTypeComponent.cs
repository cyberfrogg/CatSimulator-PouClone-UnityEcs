using Game.Utils;
using JCMG.EntitasRedux;

namespace Ecs.Game.Components
{
    [Game]
    [Event(EventTarget.Self)]
    public class MoodTypeComponent : IComponent
    {
        public EMood Value;
    }
}