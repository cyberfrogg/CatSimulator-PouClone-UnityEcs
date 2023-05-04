using Core.Utils;
using Game.Utils;
using JCMG.EntitasRedux;
using UnityEngine;
using Zenject;

namespace Ecs.Views.Linkable.Impl
{
    public class CharacterView : ObjectView, ICatInteractionTypeAddedListener
    {
        [SerializeField] private Animator _animator;

        [Inject] private GameContext _game;
        
        private bool _wasFirstPlay;

        public override void Link(IEntity entity, IContext context)
        {
            base.Link(entity, context);
            
            _game.CatEntity.AddCatInteractionTypeAddedListener(this);
        }

        public void OnCatInteractionTypeAdded(GameEntity entity, ECatInteractionType value)
        {
            if (!_wasFirstPlay)
            {
                _wasFirstPlay = true;
                return;
            }
            
            _animator.SetTrigger(AnimationKeys.Interact);
        }
    }
}