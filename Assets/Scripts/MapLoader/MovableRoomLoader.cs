using UnityEngine;
using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using Pseudo;

namespace Pseudo
{
	[Serializable]
	public class MovableRoomLoader : MonoBehaviour
	{
		private void Start()
		{
			var map = GameObject.Find("Map");
			foreach (var kid in map.GetChildren())
			{
				if (kid.name.StartsWith("_", StringComparison.Ordinal))
				{
					var room = kid.AddComponent<MovableRoom>();
					room.axe = kid.name[1] == 'x' ? Axes.X : Axes.Y;
					room.movement = int.Parse(kid.name.Substring(2, 2));
					room.HideInstant();
				}
			}
		}
	}
}
