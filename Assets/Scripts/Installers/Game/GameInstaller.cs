using Ecs.Utils.Impl;
using Game.Models.Camera.Impl;
using Game.Models.Input;
using Game.Services.Pool.Impls;
using Game.Signals;
using Libs.AnalyticsAppMetrica;
using Libs.GameAnalytics;
using Zenject;

namespace Installers.Game
{
    public class GameInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            DeclareSignals();
            Bind();
            BindAi();
            BindWindows();
            BindManagers();
        }

        private void DeclareSignals()
        {
	        Container.DeclareSignal<SignalLevelStart>();
	        Container.DeclareSignal<SignalLevelRestart>();
	        Container.DeclareSignal<SignalLevelComplete>();
	        Container.DeclareSignal<SignalLevelFail>();
        }

        private void Bind()
        {
	        AppMetricaServiceInstaller.Install(Container);
	        GameAnalyticServiceInstaller.Install(Container);
	        
            Container.Bind<LateFixedManager>().AsSingle();
            Container.Bind<LateFixedUpdate>().FromNewComponentOnNewGameObject().AsSingle().NonLazy();
            
            Container.BindInterfacesAndSelfTo<PlayerCameraHolder>().AsSingle();
        }
        
        private void BindAi()
		{
			// Container.BindInterfacesTo<AiService>().AsSingle();
			// Container.BindInterfacesTo<AiRespawnService>().AsSingle();
			//
			// Container.BindInterfacesTo<SelectorBuilder>().AsSingle();
			// Container.BindInterfacesTo<SelectorRandomBuilder>().AsSingle();
			// Container.BindInterfacesTo<SequenceBuilder>().AsSingle();
			// Container.BindInterfacesTo<InverterBuilder>().AsSingle();
			// Container.BindInterfacesTo<RepeaterBuilder>().AsSingle();
			// Container.BindInterfacesTo<ReturnSuccessBuilder>().AsSingle();
			// Container.BindInterfacesTo<ReturnFailureBuilder>().AsSingle();
			// Container.BindInterfacesTo<SuccessWithChanceActionBuilder>().AsSingle();
			//
			// Container.BindInterfacesTo<RemoveDesiredPositionActionBuilder>().AsSingle();
			// Container.BindInterfacesTo<MoveToTargetActionBuilder>().AsSingle();
			// Container.BindInterfacesTo<AttackActionBuilder>().AsSingle();
			// Container.BindInterfacesTo<IsAttackingConditionBuilder>().AsSingle();
			// Container.BindInterfacesTo<IdleActionBuilder>().AsSingle();
			// Container.BindInterfacesTo<IsTargetAvailableConditionBuilder>().AsSingle();
			// Container.BindInterfacesTo<IsRemainingDistanceLowConditionBuilder>().AsSingle();
			// Container.BindInterfacesTo<IsTargetInAttackAngleConditionBuilder>().AsSingle();
			// Container.BindInterfacesTo<IsPlayerInRadiusConditionBuilder>().AsSingle();
			// Container.BindInterfacesTo<IsTargetInAttackDistanceConditionBuilder>().AsSingle();
			// Container.BindInterfacesTo<LookToTargetActionBuilder>().AsSingle();
			// Container.BindInterfacesTo<WanderAroundHomeActionBuilder>().AsSingle();
			// Container.BindInterfacesTo<MoveStoppedConditionBuilder>().AsSingle();
			// Container.BindInterfacesTo<IsTargetInLookRangeConditionBuilder>().AsSingle();
			// Container.BindInterfacesTo<FindConstructionToAttackActionBuilder>().AsSingle();
			// Container.BindInterfacesTo<GoToNoiseActionBuilder>().AsSingle();
			// Container.BindInterfacesTo<WaitTimeActionBuilder>().AsSingle();
			// Container.BindInterfacesTo<FindRandomPointActionBuilder>().AsSingle();
			// Container.BindInterfacesTo<IsConstructionTargetConditionBuilder>().AsSingle();
			// Container.BindInterfacesTo<IsPlayerTargetConditionBuilder>().AsSingle();
			// Container.BindInterfacesTo<PathToPlayerExistsConditionBuilder>().AsSingle();
			// Container.BindInterfacesTo<HasTargetConditionBuilder>().AsSingle();
			// Container.BindInterfacesTo<ContinueGoingToTargetActionBuilder>().AsSingle();
			// Container.BindInterfacesTo<HasKeepTargetConditionBuilder>().AsSingle();
			// Container.BindInterfacesTo<KeepTargetActionBuilder>().AsSingle();
			// Container.BindInterfacesTo<ChanceIdleActionBuilder>().AsSingle();
			// Container.BindInterfacesTo<SelectorRepeaterBuilder>().AsSingle();
			// Container.BindInterfacesTo<RemoveTargetActionBuilder>().AsSingle();
			// Container.BindInterfacesTo<HasEndPointConditionBuilder>().AsSingle();
			// Container.BindInterfacesTo<WasAttackedConditionBuilder>().AsSingle();
			// Container.BindInterfacesTo<SetTargetPlayerActionBuilder>().AsSingle();
			// Container.BindInterfacesTo<SetTargetTrainActionBuilder>().AsSingle();
		}

        private void BindWindows()
        {
	        
        }

        private void BindManagers()
        {
	        Container.BindInterfacesTo<MoveController>().AsSingle();
	        Container.BindInterfacesTo<SpawnService>().AsSingle();
	        Container.BindInterfacesTo<LinkedEntityRepository>().AsSingle();
	        Container.BindInterfacesTo<PrefabPoolService>().AsSingle();
        }
    }
}