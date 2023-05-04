using Game.Utils;
using PdUtils.Interfaces;
using SimpleUi.Abstracts;
using UniRx;

namespace Game.Ui.PerformAction
{
    public class PerformActionController : UiController<PerformActionView>, IUiInitializable
    {
        private readonly ActionContext _action;

        public PerformActionController(
            ActionContext action
            )
        {
            _action = action;
        }

        public void Initialize()
        {
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