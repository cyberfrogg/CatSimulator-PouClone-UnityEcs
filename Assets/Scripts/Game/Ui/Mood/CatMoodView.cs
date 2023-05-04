using Ecs.Views.Linkable.Impl.Ui;
using UnityEngine;
using UnityEngine.UI;

namespace Game.Ui.Mood
{
    public class CatMoodView : GameLinkableUiView,
        IMoodAddedListener
    {
        [SerializeField] private Slider _slider;
        
        protected override void Listen(GameEntity entity)
        {
            entity.AddMoodAddedListener(this);
        }

        protected override void Unlisten(GameEntity entity)
        {
            entity.RemoveMoodAddedListener(this);
        }

        protected override void Reset()
        {
            
        }

        public void OnMoodAdded(GameEntity entity, float value)
        {
            _slider.value = value;
        }
    }
}