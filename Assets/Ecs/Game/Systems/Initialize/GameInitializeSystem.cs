using Ecs.Utils;
using InstallerGenerator.Attributes;
using InstallerGenerator.Enums;
using JCMG.EntitasRedux;
using UnityEngine;

namespace Ecs.Game.Systems.Initialize
{
	[Install(ExecutionType.Game, ExecutionPriority.High, 10, nameof(EFeatures.Initialization))]
	public class GameInitializeSystem : IInitializeSystem
	{
		private readonly GameContext _game;

		protected GameInitializeSystem(
			GameContext game
		)
		{
			_game = game;
		}

		public void Initialize()
		{
			Debug.Log("GameInitializeSystem");
		}
	}
}