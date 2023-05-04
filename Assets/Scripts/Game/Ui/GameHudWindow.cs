using Game.Ui.Mood;
using Game.Ui.PerformAction;
using SimpleUi;

namespace Game.Ui
{
    public class GameHudWindow : WindowBase
    {
        public override string Name => "GameHud";

        protected override void AddControllers()
        {
            AddController<PerformActionController>();
            AddController<CatMoodController>();
        }
    }
}