using Ecs.Game.Extensions;
using Ecs.Utils;
using Game.Providers;
using InstallerGenerator.Attributes;
using InstallerGenerator.Enums;
using JCMG.EntitasRedux;
using Zenject;

namespace Ecs.Game.Systems.Initialize
{
    [Install(ExecutionType.Game, ExecutionPriority.Normal, 20, nameof(EFeatures.Initialization))]
    public class CatInitializeSystem : IInitializeSystem
    {
        private readonly GameContext _game;
        private readonly DiContainer _diContainer;
        private readonly IGameFieldProvider _gameFieldProvider;
        private readonly ILinkedEntityRepository _linkedEntityRepository;

        public CatInitializeSystem(
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
            var catView = _gameFieldProvider.GameField.CatView;
            _diContainer.Inject(catView);
            var catViewTransform = catView.transform;
            var cat = _game.CreateCat(catViewTransform.position, catViewTransform.rotation, 0.5f);
            
            catView.Link(cat, _game);
            cat.AddLink(catView);
            _linkedEntityRepository.Add(catViewTransform.GetHashCode(), cat);
        }
    }
}