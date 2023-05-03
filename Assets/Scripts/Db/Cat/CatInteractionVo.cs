using System;
using Game.Utils;

namespace Db.Cat
{
    [Serializable]
    public struct CatInteractionVo
    {
        public ECatInteractionType InteractionType;
        public EMood Mood;
    }
}