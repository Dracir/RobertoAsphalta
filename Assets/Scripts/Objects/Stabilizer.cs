using UnityEngine;
using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using Pseudo;

namespace Pseudo
{
	[Serializable]
	public class Stabilizer : MonoBehaviour
	{
		public bool Stabilizing = false;
		float lastHit;
		public float DestabilizeAfter;

		private void Update()
		{
			if (!Stabilizing) return;

			if(UnityEngine.Time.time > lastHit + DestabilizeAfter) 
			{
				Stabilizing = false;
			}
		}

		public void LaserHit()
		{
			Stabilizing = true;
			lastHit = UnityEngine.Time.time;
		}
	}
}
