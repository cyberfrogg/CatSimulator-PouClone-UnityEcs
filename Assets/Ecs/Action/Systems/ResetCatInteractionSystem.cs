using System.Collections.Generic;
using Ecs.Core.Systems;
using Ecs.Utils;
using Game.Utils;
using InstallerGenerator.Attributes;
using InstallerGenerator.Enums;
using JCMG.EntitasRedux;
using UnityEngine;

namespace Ecs.Action.Systems
{
    [Install(ExecutionType.Game, ExecutionPriority.Normal, 800, nameof(EFeatures.Cat))]
    public class ResetCatInteractionSystem : AReactiveSystemWithPool<ActionEntity>
    {
        private readonly GameContext _game;

        public ResetCatInteractionSystem(
            ActionContext action,
            GameContext game
            ) : base(action)
        {
            _game = game;
        }

        protected override ICollector<ActionEntity> GetTrigger(IContext<ActionEntity> context)
            => context.CreateCollector(ActionMatcher.ResetCatInteraction);

        protected override bool Filter(ActionEntity entity)
            => entity.IsResetCatInteraction && !entity.IsDestroyed;

        protected override void Execute(List<ActionEntity> actions)
        {
            foreach (var action in actions)
            {
                action.IsDestroyed = true;

                var cat = _game.CatEntity;
                cat.ReplaceCatInteractionType(ECatInteractionType.None);
                
                Debug.Log("Resetting cat interaction");
            }
        }
    }
}