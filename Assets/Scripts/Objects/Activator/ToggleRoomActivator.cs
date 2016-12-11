using UnityEngine;
using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using Pseudo;

namespace Pseudo
{
	[Serializable]
	public class ToggleRoomActivator : MonoBehaviour, IActivable
	{

		public MovableRoom Room;

		public BoolProperty IsOpen;

		public void Activate()
		{
			if (IsOpen.Value)
			{
				Room.Show();
			}
			else
			{
				Room.Hide();
			}
		}
	}
}
