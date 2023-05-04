using Ecs.Views.Linkable.Impl;
using UnityEngine;

namespace Game.Utils
{
    public class GameField : MonoBehaviour
    {
        [SerializeField] private CatView catView;
        [SerializeField] private CharacterView characterView;
        [SerializeField] private Transform cameraPoint;
        
        public CatView CatView => catView;
        public CharacterView CharacterView => characterView;
        public Transform CameraPoint => cameraPoint;

        private void OnDrawGizmos()
        {
            var cameraPointLook = cameraPoint.rotation * Vector3.forward;
            Gizmos.DrawLine(cameraPoint.position, cameraPoint.position + cameraPointLook);
        }
    }
}