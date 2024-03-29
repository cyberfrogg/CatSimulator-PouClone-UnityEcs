using Game.Ui.Mood;
using Game.Ui.PerformAction;
using SimpleUi;
using UnityEngine;
using Zenject;

namespace Installers.Game
{
    
    [CreateAssetMenu(menuName = "Installers/" + nameof(GameUiPrefabInstaller), fileName = nameof(GameUiPrefabInstaller))]
    public class GameUiPrefabInstaller : ScriptableObjectInstaller
    {
        [SerializeField] private Canvas canvas;

        [SerializeField] private PerformActionView performActionView;
        [SerializeField] private CatMoodView catMoodView;
         
        public override void InstallBindings()
        {
            var canvasView = Container.InstantiatePrefabForComponent<Canvas>(canvas);
            var canvasTransform = canvasView.transform;
            
            var camera = canvasTransform.GetComponentInChildren<Camera>();
            
            Container.BindUiView<PerformActionController, PerformActionView>(performActionView, canvasTransform);
            Container.BindUiView<CatMoodController, CatMoodView>(catMoodView, canvasTransform);
        }
    }
}