using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace MultiScreenshotCaptureNamespace
{
	public class MutilScreenHotKey : MonoBehaviour
	{
		public static event Action OnKeyDown;
		public static MutilScreenHotKey Instance;

		private KeyCode captureKey = KeyCode.Space;


		public void SetKey(KeyCode _key)
		{
			captureKey = _key;
		}

		private void Update()
		{

			if (Input.GetKeyDown(captureKey))
			{
				OnKeyDown?.Invoke();
			} 

		}
	}
}
