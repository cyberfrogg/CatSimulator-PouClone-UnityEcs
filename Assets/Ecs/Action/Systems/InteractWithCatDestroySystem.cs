using System.Collections.Generic;
using Ecs.Core.Systems;
using Ecs.Utils;
using InstallerGenerator.Attributes;
using InstallerGenerator.Enums;
using JCMG.EntitasRedux;
using UnityEngine;

namespace Ecs.Action.Systems
{
    [Install(ExecutionType.Game, ExecutionPriority.Normal, 1800, nameof(EFeatures.Cat))]
    public class InteractWithCatDestroySystem : AReactiveSystemWithPool<ActionEntity>
    {
        public InteractWithCatDestroySystem(
            ActionContext action
            ) : base(action)
        {
            
        }

        protected override ICollector<ActionEntity> GetTrigger(IContext<ActionEntity> context)
            => context.CreateCollector(ActionMatcher.InteractWithCat);

        protected override bool Filter(ActionEntity entity)
            => entity.HasInteractWithCat && !entity.IsDestroyed;

        protected override void Execute(List<ActionEntity> actions)
        {
            foreach (var action in actions)
            {
                Debug.Log($"Interact with cat pipeline has been completed. Interaction type: {action.InteractWithCat.InteractionType}");
                action.IsDestroyed = true;
            }
        }
    }
}