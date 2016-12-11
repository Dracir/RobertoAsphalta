using UnityEngine;
using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using Pseudo;

namespace Pseudo
{
	[Serializable]
	public class SpriteTogleActivator : MonoBehaviour, IActivable
	{
		[Disable]
		public bool activated = false;

		public Sprite OnSprite;
		public Sprite OffSprite;

		SpriteRenderer sprite;

		private void Awake()
		{
			sprite = GetComponentInChildren<SpriteRenderer>();
		}

		public void Activate()
		{
			if (activated)
			{
				sprite.sprite = OffSprite;
			}
			else
			{
				sprite.sprite = OnSprite;
			}
			activated = !activated;
		}
	}
}
