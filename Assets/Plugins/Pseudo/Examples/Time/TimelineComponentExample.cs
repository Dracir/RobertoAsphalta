using UnityEngine;
using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using Pseudo;
using Pseudo.Time;

namespace Pseudo.Time.Examples
{
	/// <summary>
	/// Destroys the <i>gameObject</i> after the given lifeTime. You can play with the <i>timeScale</i> in the <i>TimeComponent</i> on the <i>gameobject</i>.
	/// </summary>
	public class TimelineComponentExample : MonoBehaviour
	{
		public TimelineComponent Timeline;
		public float LifeTime;

		void Start()
		{
			Timeline.Schedule(c => {
				gameObject.Destroy();
			}).In(LifeTime);
		}
	}
}
