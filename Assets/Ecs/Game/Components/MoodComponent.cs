using Game.Utils;
using JCMG.EntitasRedux;

namespace Ecs.Game.Components
{
    [Game]
    public class MoodComponent : IComponent
    {
        public EMood Value;
    }
}