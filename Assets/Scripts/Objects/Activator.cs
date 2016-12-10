using UnityEngine;
using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using Pseudo;

namespace Pseudo
{
	[Serializable]
	public class Activator : MonoBehaviour
	{
		public BoxCollider2D TheCollider;
		public bool PlayerNear;
	
		private void OnDrawGizmos()
		{
			if (TheCollider == null) return;

			Gizmos.color = Color.red;			
			Gizmos.DrawWireCube(TheCollider.transform.position, TheCollider.size);
		}

		private void Update()
		{
			if(Input.GetKeyDown(KeyCode.Space))
			{
				var activatable = GetComponentInParent<IActivable>();
				if(activatable != null)
					activatable.Activate();
			}
		}

		private void OnTriggerEnter2D(Collider2D collision)
		{
			if(collision.tag == "Player") {
				PlayerNear = true;
			}
		}

		private void OnTriggerExit2D(Collider2D collision)
		{
			if (collision.tag == "Player")
			{
				PlayerNear = false;
			}
		}
	}
}
