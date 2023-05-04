using System;
using System.Collections.Generic;
using Game.Utils;
using Game.Utils.Drawers;
using SimpleUi.Abstracts;
using UnityEngine;
using UnityEngine.UI;

namespace Game.Ui.PerformAction
{
    public class PerformActionView : UiView
    {
        [KeyValueFormat(nameof(PerformActionViewButtonsPair.CatInteractionType))] 
        [SerializeField] 
        private List<PerformActionViewButtonsPair> buttons;

        public List<PerformActionViewButtonsPair> Buttons => buttons;
    }

    [Serializable]
    public class PerformActionViewButtonsPair
    {
        public ECatInteractionType CatInteractionType;
        public Button Button;
    }
}