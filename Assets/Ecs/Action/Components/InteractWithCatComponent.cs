using Game.Utils;
using JCMG.EntitasRedux;

namespace Ecs.Action.Components
{
    [Action]
    public class InteractWithCatComponent : IComponent
    {
        public ECatInteractionType InteractionType;
    }
}