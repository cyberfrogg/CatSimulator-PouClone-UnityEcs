using System.Collections.Generic;
using Db.Cat;
using Ecs.Core.Systems;
using Ecs.Utils;
using InstallerGenerator.Attributes;
using InstallerGenerator.Enums;
using JCMG.EntitasRedux;
using UnityEngine;

namespace Ecs.Action.Systems
{
    [Install(ExecutionType.Game, ExecutionPriority.Normal, 605, nameof(EFeatures.Cat))]
    public class InteractWithCatBaseSystem : AReactiveSystemWithPool<ActionEntity>
    {
        private readonly ICatInteractionParametersBase _catInteractionParametersBase;
        private readonly GameContext _game;

        public InteractWithCatBaseSystem(
            ActionContext action,
            ICatInteractionParametersBase catInteractionParametersBase,
            GameContext game
            ) : base(action)
        {
            _catInteractionParametersBase = catInteractionParametersBase;
            _game = game;
        }

        protected override ICollector<ActionEntity> GetTrigger(IContext<ActionEntity> context)
            => context.CreateCollector(ActionMatcher.InteractWithCat);

        protected override bool Filter(ActionEntity entity)
            => entity.HasInteractWithCat && !entity.IsDestroyed;

        protected override void Execute(List<ActionEntity> actions)
        {
            foreach (var action in actions)
            {
                var interactionType = action.InteractWithCat.InteractionType;
                var interactionVo = _catInteractionParametersBase.GetInteraction(interactionType);
                
                // replace current interaction
                _game.CatEntity.ReplaceCatInteractionType(interactionType);

                // replace mood
                var catMood = _game.CatEntity.Mood.Value;
                catMood += interactionVo.MoodAddValue;
                catMood = Mathf.Clamp01(catMood);
                _game.CatEntity.ReplaceMood(catMood);
            }
        }
    }
}