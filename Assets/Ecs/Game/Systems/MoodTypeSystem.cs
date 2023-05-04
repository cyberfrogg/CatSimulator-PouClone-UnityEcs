using System.Collections.Generic;
using Ecs.Core.Systems;
using Ecs.Utils;
using Game.Services.Mood;
using InstallerGenerator.Attributes;
using InstallerGenerator.Enums;
using JCMG.EntitasRedux;

namespace Ecs.Game.Systems
{
    [Install(ExecutionType.Game, ExecutionPriority.Normal, 300, nameof(EFeatures.Common))]
    public class MoodTypeSystem : AReactiveSystemWithPool<GameEntity>
    {
        private readonly IMoodService _moodService;

        public MoodTypeSystem(
            GameContext game,
            IMoodService moodService
            ) : base(game)
        {
            _moodService = moodService;
        }

        protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
            => context.CreateCollector(GameMatcher.Mood);

        protected override bool Filter(GameEntity entity)
            => entity.HasMood && entity.HasMoodType && !entity.IsDestroyed;

        protected override void Execute(List<GameEntity> entities)
        {
            foreach (var entity in entities)
            {
                if (entity.IsCat)
                {
                    var moodType = _moodService.GetCatMood(entity);
                    entity.ReplaceMoodType(moodType);
                }
            }
        }
    }
}