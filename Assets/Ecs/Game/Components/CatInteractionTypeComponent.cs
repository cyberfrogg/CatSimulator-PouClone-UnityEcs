using Game.Utils;
using JCMG.EntitasRedux;

namespace Ecs.Game.Components
{
    [Game]
    [Event(EventTarget.Self)]
    public class CatInteractionTypeComponent : IComponent
    {
        public ECatInteractionType Value;
    }
}