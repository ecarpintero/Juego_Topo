using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimiento_topo : MonoBehaviour {

	public float velocidad_x = 0.5f;
	public float velocidad_y = 0.5f;

	private Transform tr;

	// Use this for initialization
	void Start () {
		tr = this.transform;
	}
	
	// Update is called once per frame
	void Update () {
		movimiento ();
	}

	void movimiento()
	{
		float velocidad_in_x = 0.0f;
		float velocidad_in_y = 0.0f;
		if (Input.GetKey (KeyCode.LeftArrow)) {
			velocidad_in_x = velocidad_x * -1;
		}


		tr.transform.Translate (velocidad_in_x,0,0);

	}
}
