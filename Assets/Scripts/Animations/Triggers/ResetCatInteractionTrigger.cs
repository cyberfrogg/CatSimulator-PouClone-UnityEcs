using UniRx.Triggers;
using UnityEngine;

namespace Animations.Triggers
{
    public class ResetCatInteractionTrigger : ObservableStateMachineTrigger
    {
        public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            base.OnStateExit(animator, stateInfo, layerIndex);

            Contexts.SharedInstance.Action.CreateEntity().IsResetCatInteraction = true;
        }
    }
}