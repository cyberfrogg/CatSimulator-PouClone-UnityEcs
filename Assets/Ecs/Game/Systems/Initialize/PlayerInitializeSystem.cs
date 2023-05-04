using Ecs.Game.Extensions;
using Ecs.Utils;
using Game.Providers;
using InstallerGenerator.Attributes;
using InstallerGenerator.Enums;
using JCMG.EntitasRedux;
using Zenject;

namespace Ecs.Game.Systems.Initialize
{
    [Install(ExecutionType.Game, ExecutionPriority.Normal, 30, nameof(EFeatures.Initialization))]
    public class PlayerInitializeSystem : IInitializeSystem
    {
        private readonly GameContext _game;
        private readonly DiContainer _diContainer;
        private readonly IGameFieldProvider _gameFieldProvider;
        private readonly ILinkedEntityRepository _linkedEntityRepository;

        public PlayerInitializeSystem(
            GameContext game,
            DiContainer diContainer,
            IGameFieldProvider gameFieldProvider,
            ILinkedEntityRepository linkedEntityRepository
        )
        {
            _game = game;
            _diContainer = diContainer;
            _gameFieldProvider = gameFieldProvider;
            _linkedEntityRepository = linkedEntityRepository;
        }

        public void Initialize()
        {
            var characterView = _gameFieldProvider.GameField.CharacterView;
            _diContainer.Inject(characterView);
            var characterViewTransform = characterView.transform;
            var cat = _game.CreatePlayer(characterViewTransform.position, characterViewTransform.rotation);
            
            characterView.Link(cat, _game);
            cat.AddLink(characterView);
            _linkedEntityRepository.Add(characterViewTransform.GetHashCode(), cat);
        }
    }
}