using UnityEngine;
using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using Pseudo;

namespace Pseudo
{
	[Serializable]
	public class MovableRoom : MonoBehaviour
	{
		public Axes axe;
		public int movement;

		public void Hide()
		{
			transform.Translate(movement, axe);
			gameObject.SetActive(false);
		}

		public void HideInstant()
		{
			transform.Translate(movement, axe);
			gameObject.SetActive(false);
		}

		public void Show()
		{
			transform.Translate(-movement, axe);
			gameObject.SetActive(true);
		}
	}
}
