using UnityEngine;
using System;
using Pseudo;

namespace Pseudo.Time.Examples
{
	/// <summary>
	/// Destroys the <i>gameObject</i> after the given lifeTime. You can play with the <i>timeScale</i> in the <i>TimeComponent</i> on the <i>gameobject</i>.
	/// </summary>
	public class TimeComponentExample : MonoBehaviour
	{
		public TimeComponent TimeChannel;
		public float LifeTime = 2;

		float t;

		void Update()
		{
			t += TimeChannel.DeltaTime;
			if (t >= LifeTime)
			{
				gameObject.Destroy();
			}
		}
	}
}