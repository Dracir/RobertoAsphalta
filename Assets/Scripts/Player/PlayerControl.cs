using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour {

	public float MoveSpeed;

	void Start () {
		
	}
	
	void Update () {
		var x = 0;
		var y = 0;

		if(Input.GetKey(KeyCode.W)) {
			y = 1;
		}
		if (Input.GetKey(KeyCode.S))
		{
			y = -1;
		}
		if (Input.GetKey(KeyCode.D))
		{
			x = 1;
		}
		if (Input.GetKey(KeyCode.A))
		{
			x = -1;
		}
		transform.Translate(new Vector2(x, y).normalized * MoveSpeed * Time.deltaTime);
	}
}
