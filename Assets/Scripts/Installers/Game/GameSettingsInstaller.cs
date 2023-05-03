using Db.Ai;
using Db.Ai.Impl;
using Db.Fx;
using Db.Fx.Impl;
using Db.Objects;
using Db.Objects.Impl;
using Db.Prefabs;
using Db.Prefabs.Impls;
using UnityEngine;
using Zenject;
using ZenjectUtil.Test.Extensions;

namespace Installers.Game
{
    [CreateAssetMenu(menuName = "Installers/" + nameof(GameSettingsInstaller), fileName = nameof(GameSettingsInstaller))]
    public class GameSettingsInstaller : ScriptableObjectInstaller
    {
        [SerializeField] private EnemySettingsBase enemySettingsBase;
        [SerializeField] private PrefabsBase prefabsBase;
        [SerializeField] private ObjectBase objectBase;
        [SerializeField] private FxObjectBase fxObjectBase;
        
        public override void InstallBindings()
        {
            Container.Bind<IEnemySettingsBase>().FromSubstitute(enemySettingsBase).AsSingle();
            Container.Bind<IPrefabsBase>().FromSubstitute(prefabsBase).AsSingle();
            Container.Bind<IObjectBase>().FromSubstitute(objectBase).AsSingle();
            Container.Bind<IFxObjectBase>().FromSubstitute(fxObjectBase).AsSingle();
        }
    }
}