using Core.Utils;
using Game.Utils;
using JCMG.EntitasRedux;
using UnityEngine;

namespace Ecs.Views.Linkable.Impl
{
    public class CatView : ObjectView,
        IMoodTypeAddedListener,
        ICatInteractionTypeAddedListener
    {
        [SerializeField] private Animator _animator;

        private GameEntity _self;

        private bool _wasFirstPlay;
        private EMood _previousMoodType;
        
        public override void Link(IEntity entity, IContext context)
        {
            _self = (GameEntity)entity;
            
            base.Link(entity, context);
            
            _self.AddMoodTypeAddedListener(this);
            _self.AddCatInteractionTypeAddedListener(this);
        }

        public void OnMoodTypeAdded(GameEntity entity, EMood value)
        {
            _animator.SetInteger(AnimationKeys.MoodType, (int)_previousMoodType);
            _previousMoodType = _self.MoodType.Value;
        }

        public void OnCatInteractionTypeAdded(GameEntity entity, ECatInteractionType value)
        {
            if (!_wasFirstPlay)
            {
                _wasFirstPlay = true;
                return;
            }
            
            _animator.SetTrigger(AnimationKeys.Interact);
            _animator.SetInteger(AnimationKeys.InteractionType, (int)value);
        }
    }
}