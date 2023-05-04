using System;
using System.Collections.Generic;
using Ecs.Views.Linkable.Impl.Ui;
using Game.Utils;
using Game.Utils.Drawers;
using UnityEngine;
using UnityEngine.UI;

namespace Game.Ui.PerformAction
{
    public class PerformActionView : GameLinkableUiView,
        ICatInteractionTypeAddedListener
    {
        [KeyValueFormat(nameof(PerformActionViewButtonsPair.CatInteractionType))] 
        [SerializeField] 
        private List<PerformActionViewButtonsPair> buttons;

        public List<PerformActionViewButtonsPair> Buttons => buttons;
        
        protected override void Listen(GameEntity entity)
        {
            entity.AddCatInteractionTypeAddedListener(this);
        }
        protected override void Unlisten(GameEntity entity)
        {
            entity.RemoveCatInteractionTypeAddedListener(this);
        }
        protected override void Reset()
        {
            
        }

        public void OnCatInteractionTypeAdded(GameEntity entity, ECatInteractionType value)
        {
            var isButtonsInteractable = value == ECatInteractionType.None;

            foreach (var button in buttons)
            {
                button.Button.interactable = isButtonsInteractable;
            }
        }
    }

    [Serializable]
    public class PerformActionViewButtonsPair
    {
        public ECatInteractionType CatInteractionType;
        public Button Button;
    }
}