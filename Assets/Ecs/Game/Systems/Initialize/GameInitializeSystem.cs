using Ecs.Utils;
using Game.Ui;
using InstallerGenerator.Attributes;
using InstallerGenerator.Enums;
using JCMG.EntitasRedux;
using SimpleUi.Signals;
using UnityEngine;
using Zenject;

namespace Ecs.Game.Systems.Initialize
{
	[Install(ExecutionType.Game, ExecutionPriority.High, 10, nameof(EFeatures.Initialization))]
	public class GameInitializeSystem : IInitializeSystem
	{
		private readonly SignalBus _signalBus;
		private readonly GameContext _game;

		protected GameInitializeSystem(
			SignalBus signalBus,
			GameContext game
		)
		{
			_signalBus = signalBus;
			_game = game;
		}

		public void Initialize()
		{
			Debug.Log("GameInitializeSystem");

			_signalBus.OpenWindow<GameHudWindow>();
		}
	}
}