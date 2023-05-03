using System.Collections.Generic;
using Game.Utils.Drawers;
using UnityEngine;

namespace Db.Cat.Impl
{
    [CreateAssetMenu(menuName = "Settings/ " + nameof(CatInteractionParametersBase), fileName = nameof(CatInteractionParametersBase))]
    public class CatInteractionParametersBase : ScriptableObject, ICatInteractionParametersBase
    {
        [KeyValueFormat("{1} - {0}", nameof(CatInteractionVo.InteractionType), nameof(CatInteractionVo.Mood))] 
        [SerializeField] private List<CatInteractionVo> _interactions;

        public List<CatInteractionVo> Interactions => _interactions;
    }
}