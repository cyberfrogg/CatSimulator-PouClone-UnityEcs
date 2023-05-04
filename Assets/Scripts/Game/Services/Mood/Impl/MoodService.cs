using Db.Cat;
using Game.Utils;
using UnityEngine;

namespace Game.Services.Mood.Impl
{
    public class MoodService : IMoodService
    {
        private readonly ICatParametersBase _catParametersBase;

        public MoodService(ICatParametersBase catParametersBase)
        {
            _catParametersBase = catParametersBase;
        }

        public EMood GetCatMood(GameEntity entity)
        {
            var moodValue = entity.Mood.Value;

            if (0 <= moodValue && moodValue <= _catParametersBase.AngryMoodValue)
            {
                return EMood.Angry;
            }
            
            if (_catParametersBase.AngryMoodValue <= moodValue && moodValue <= _catParametersBase.NeutralMoodValue)
            {
                return EMood.Neutral;
            }
            
            if (_catParametersBase.NeutralMoodValue <= moodValue && moodValue <= _catParametersBase.HappyMoodValue)
            {
                return EMood.Happy;
            }

            Debug.LogError($"Not defined rule for mood value: {moodValue}. Returning previous value");
            return entity.MoodType.Value;
        }
    }
}