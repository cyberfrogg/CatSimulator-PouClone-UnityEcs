using System.Collections.Generic;
using Ecs.Core.Systems;
using Ecs.Utils;
using Game.Models.Camera;
using Game.Providers;
using InstallerGenerator.Attributes;
using InstallerGenerator.Enums;
using JCMG.EntitasRedux;

namespace Ecs.Game.Systems.Initialize
{
    [Install(ExecutionType.Game, ExecutionPriority.Normal, 705, nameof(EFeatures.Camera))]
    public class CameraTargetInitializeSystem : AReactiveSystemWithPool<GameEntity>
    {
        private readonly IGameFieldProvider _gameFieldProvider;
        private readonly IPlayerCameraHolder _playerCameraHolder;

        public CameraTargetInitializeSystem(
            GameContext game,
            IGameFieldProvider gameFieldProvider,
            IPlayerCameraHolder playerCameraHolder
            ) : base(game)
        {
            _gameFieldProvider = gameFieldProvider;
            _playerCameraHolder = playerCameraHolder;
        }

        protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
            => context.CreateCollector(GameMatcher.Instantiate);

        protected override bool Filter(GameEntity entity)
            => entity.IsCamera && entity.IsInstantiate && !entity.IsDestroyed;

        protected override void Execute(List<GameEntity> entities)
        {
            var cam = _playerCameraHolder.VirtualCameras[0];
            cam.m_Follow = _gameFieldProvider.GameField.CameraPoint;
            cam.m_LookAt = _gameFieldProvider.GameField.CameraPoint;
        }
    }
}