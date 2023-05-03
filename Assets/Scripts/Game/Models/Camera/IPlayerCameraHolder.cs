using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

namespace Game.Models.Camera
{
	public interface IPlayerCameraHolder : ICameraHolder
	{
		float TargetHeight { get; set; }
		Transform GetProjectilePlace { get; }
		Transform Follow { get; set; }
		Transform LookAt { get; set; }
		void Init(CinemachineVirtualCamera thirdPersonCamera, CinemachineVirtualCamera firstPersonCamera);
		IReadOnlyList<CinemachineVirtualCamera> VirtualCameras { get; }
		CinemachineVirtualCamera GetThirdPersonVc();
		CinemachineVirtualCamera GetFirstPersonVc();
		void Update();
		void SetEnabled(bool enabled);
		void SetFirstPerson(bool firstPerson);

		T GetLiveCameraComponent<T>(CinemachineCore.Stage stage) where T : CinemachineComponentBase;
	}
}