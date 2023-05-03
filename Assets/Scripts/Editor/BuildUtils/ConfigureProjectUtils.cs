﻿using System;
using System.IO;
using System.Linq;
using UnityEngine;

namespace BuildUtils
{
	public static class ConfigureProjectUtils
	{
		public static void SetTargetStore(EStoreType storeType)
		{
			switch (storeType)
			{
				case EStoreType.Editor:
					break;
				case EStoreType.AppStore:
					break;
				case EStoreType.GooglePlay:
				case EStoreType.Amazon:
				case EStoreType.Huawei:
				case EStoreType.Samsung:
					break;
				default:
					throw new ArgumentOutOfRangeException(nameof(storeType), storeType, null);
			}
		}

		private static void ConfigureAndroid(EStoreType storeType)
		{
			var dataPath = Application.dataPath;
			var androidFolder = Path.Combine(dataPath, "Plugins", "Android");
			var storeFolder = Path.Combine(dataPath, "Plugins", "AndroidStore", storeType.ToString());

			var files = Directory.GetFiles(androidFolder, "*", SearchOption.AllDirectories);
			foreach (var file in files)
				File.Delete(file);

			var directories = Directory.GetDirectories(androidFolder, "*", SearchOption.AllDirectories);
			foreach (var directory in directories)
			{
				if (!Directory.Exists(directory))
					continue;

				Directory.Delete(directory, true);
			}

			var storeFiles = Directory.GetFiles(storeFolder, "*", SearchOption.AllDirectories);
			var destinationFiles = storeFiles.Select(s => s.Replace(storeFolder, androidFolder)).ToArray();
			for (var i = 0; i < storeFiles.Length; i++)
			{
				var storeFile = new FileInfo(storeFiles[i]);
				var destinationFile = new FileInfo(destinationFiles[i]);
				var destFileDirectory = destinationFile.Directory;
				if (!destFileDirectory.Exists)
					destFileDirectory.Create();

				storeFile.CopyTo(destinationFile.FullName, true);
			}
		}
	}
}