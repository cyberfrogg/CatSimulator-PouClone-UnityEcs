using System;
using System.Collections.Generic;
using UnityEngine;
using Utils.Drawers.Key;

namespace Db.Ai.Impl
{
	[CreateAssetMenu(menuName = "Settings/Ai/" + nameof(EnemySettingsBase), fileName = nameof(EnemySettingsBase))]
	public class EnemySettingsBase : ScriptableObject, IEnemySettingsBase
	{
		[KeyValue("enemyType")] [SerializeField]
		private List<EnemySettingsVo> settings;

		public List<EnemySettingsVo> Settings => settings;

		public EnemySettingsVo Get(EEnemyType enemyType)
		{
			foreach (var settingsVo in settings)
			{
				if (settingsVo.enemyType == enemyType)
					return settingsVo;
			}

			throw new Exception(
				$"[{nameof(EnemySettingsBase)}] Cannot find settings for enemy type: {enemyType}");
		}
	}
}