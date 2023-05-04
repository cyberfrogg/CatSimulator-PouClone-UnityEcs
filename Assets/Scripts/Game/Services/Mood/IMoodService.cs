using Game.Utils;

namespace Game.Services.Mood
{
    public interface IMoodService
    {
        EMood GetCatMood(GameEntity entity);
    }
}