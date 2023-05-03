using System.Collections.Generic;

namespace Db.Ai
{
	public interface IEnemySettingsBase
	{
		List<EnemySettingsVo> Settings { get; }

		EnemySettingsVo Get(EEnemyType enemyType);
	}
}