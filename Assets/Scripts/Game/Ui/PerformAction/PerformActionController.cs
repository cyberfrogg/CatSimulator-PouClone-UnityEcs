using Game.Utils;
using PdUtils.Interfaces;
using SimpleUi.Abstracts;
using UniRx;

namespace Game.Ui.PerformAction
{
    public class PerformActionController : UiController<PerformActionView>, IUiInitializable
    {
        private readonly ActionContext _action;
        private readonly GameContext _game;

        public PerformActionController(
            ActionContext action,
            GameContext game
            )
        {
            _action = action;
            _game = game;
        }

        public void Initialize()
        {
            var cat = _game.CatEntity;
            View.Link(cat, _game);
            
            foreach (var button in View.Buttons)
            {
                button.Button.OnClickAsObservable().Subscribe(_ => OnInteractButtonClick(button.CatInteractionType)).AddTo(View);
            }
        }

        private void OnInteractButtonClick(ECatInteractionType catInteractionType)
        {
            _action.CreateEntity().AddInteractWithCat(catInteractionType);
        }
    }
}