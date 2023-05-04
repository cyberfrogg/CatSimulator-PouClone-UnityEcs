using PdUtils.Interfaces;
using SimpleUi.Abstracts;

namespace Game.Ui.Mood
{
    public class CatMoodController : UiController<CatMoodView>, IUiInitializable
    {
        private readonly GameContext _game;

        public CatMoodController(
            GameContext game
            )
        {
            _game = game;
        }

        public void Initialize()
        {
            View.Link(_game.CatEntity, _game);
        }
    }
}