using System;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

namespace Game.Models.Camera.Impl
{
	public class PlayerCameraHolder : IPlayerCameraHolder
	{
		private Transform _follow;
		private Transform _lookAt;
		private UnityEngine.Camera _camera;
		private Transform _projectilePlace;
		private CinemachineBrain _brain;
		private CinemachineVirtualCamera _thirdPersonCamera;
		private CinemachineVirtualCamera _firstPersonCamera;

		public float TargetHeight
		{
			get
			{
				if (_follow == null)
				{
					Debug.LogError($"[{nameof(PlayerCameraHolder)}] Camera holder isn't initialized");
					return 0;
				}

				return _follow.localPosition.y;
			}
			set
			{
				if (_follow == null)
				{
					Debug.LogError($"[{nameof(PlayerCameraHolder)}] Camera holder isn't initialized");
					return;
				}

				var lookPos = _follow.localPosition;
				lookPos.y = value;
				_follow.localPosition = lookPos;
			}
		}

		public Transform LookAt
		{
			get => _lookAt;
			set
			{
				_lookAt = value;
				SetLookAtTarget(_lookAt);
			}
		}

		public Transform Follow
		{
			get => _follow;
			set
			{
				_follow = value;
				SetFollowTarget(_lookAt);
			}
		}

		public void SetEnabled(bool enabled)
		{
			_camera.enabled = enabled;
		}

		public void SetFirstPerson(bool firstPerson)
		{
			_firstPersonCamera.enabled = firstPerson;
			_thirdPersonCamera.enabled = !firstPerson;
		}

		public T GetLiveCameraComponent<T>(CinemachineCore.Stage stage)
			where T : CinemachineComponentBase
		{
			var camera = _thirdPersonCamera.enabled ? _thirdPersonCamera : _firstPersonCamera;
			return camera.GetCinemachineComponent(stage) as T;
		}

		public void Init(CinemachineVirtualCamera thirdPersonCamera, CinemachineVirtualCamera firstPersonCamera)
		{
			_thirdPersonCamera = thirdPersonCamera;
			_firstPersonCamera = firstPersonCamera;
			VirtualCameras = new CinemachineVirtualCamera[]
			{
				thirdPersonCamera, firstPersonCamera
			};
			SetFollowTarget(_follow);
			SetLookAtTarget(_lookAt);
		}

		public IReadOnlyList<CinemachineVirtualCamera> VirtualCameras { get; private set; } =
			Array.Empty<CinemachineVirtualCamera>();

		public CinemachineVirtualCamera GetThirdPersonVc()
		{
			return _thirdPersonCamera;
		}

		public CinemachineVirtualCamera GetFirstPersonVc()
		{
			return _firstPersonCamera;
		}

		private void SetFollowTarget(Transform follow)
		{
			if (_thirdPersonCamera)
				_thirdPersonCamera.Follow = follow;
			if (_firstPersonCamera)
				_firstPersonCamera.Follow = follow;
		}

		private void SetLookAtTarget(Transform lookAt)
		{
			if (_thirdPersonCamera)
				_thirdPersonCamera.LookAt = lookAt;
			if (_firstPersonCamera)
				_firstPersonCamera.LookAt = lookAt;
		}

		public void SetCamera(UnityEngine.Camera camera)
		{
			_camera = camera;
		}

		public void SetBrain(CinemachineBrain brain)
		{
			_brain = brain;
		}

		public void SetProjectilePlace(Transform projectilePlace)
		{
			_projectilePlace = projectilePlace;
		}


		public UnityEngine.Camera GetCamera() => _camera;

		public Vector3 GetPlayerCameraDirection(Vector3 target)
		{
			return target - _camera.transform.position;
		}

		public Transform GetProjectilePlace => _projectilePlace;


		public void Update()
		{
			if (_brain == null)
				return;

			_brain.ManualUpdate();
			SetRotationZToZero();
		}

		private void SetRotationZToZero()
		{
			var transform = _camera.transform;
			var rotation = transform.rotation;
			var eulerAngles = rotation.eulerAngles;
			eulerAngles.z = 0;
			rotation.eulerAngles = eulerAngles;
			transform.rotation = rotation;
		}
	}
}