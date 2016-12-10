using UnityEngine;
using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using Pseudo;

namespace Pseudo
{
	[Serializable]
	public class LaserSource : MonoBehaviour, IActivable
	{
		public Transform FireSource;
		public LineRenderer Line;

		public LayerMask HitTarget;
		public bool firing = true;

		private void Start()
		{
			Line.SetPosition(0, FireSource.position + Vector3.back);
		}

		void Update()
		{
			if (!firing) return;

			DoRay(1, FireSource, Vector2.left);
		}

		void DoRay(int index, Transform source, Vector2 direction) 
		{
			if (index > 10) return;

			RaycastHit2D hit = Physics2D.Raycast(source.position, direction, Mathf.Infinity, HitTarget);
			if (hit.collider != null)
			{
				if (Line.numPositions <= index) Line.numPositions++;

				Line.SetPosition(index, hit.transform.position + Vector3.back);

				var stabilizer = hit.collider.transform.GetComponentInParent<Stabilizer>();
				if (stabilizer)
					stabilizer.LaserHit();


				var mirror = hit.collider.transform.GetComponentInParent<Mirror>();
				if (mirror)
					DoRay(index + 1, mirror.transform, mirror.Direction);
					//Debug.Log(mirror.Direction);
			}
			
		}

		public void Activate()
		{
			if (firing)
			{
				Line.gameObject.SetActive(false);
			}
			else
			{
				Line.gameObject.SetActive(true);
			}
			firing = !firing;
		}
	}
}
