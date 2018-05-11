using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class movement : MonoBehaviour {
	Rigidbody rb;
	Transform tr;
	float v;
	float x;
	float y;
	float f;
	float ff;
	public Rigidbody MainObject;
	public Transform dulo;
	public Transform rot;
	public Camera  cam;
	public Canvas can;
	Camera camoff;
	Rigidbody clone;
	Transform dd;
	Animator anim;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		tr = GetComponent<Transform> ();
		anim = GetComponent<Animator> ();
		camoff = GetComponent<Camera> ();
	
	}
	
	// Update is called once per frame
	void Update () {
		v = Input.GetAxis ("Vertical");
		rb.AddForce (tr.forward * v * 140f);

		x = Input.GetAxis ("Mouse X");

		Vector3 rotation = new Vector3 (0, x, 0);
		tr.Rotate (rotation*5f);

		f = Input.GetAxis ("Fire1");
		if (f > 0) {
			clone = Instantiate (MainObject, dulo.position, dulo.rotation   );
			clone.AddForce (tr.forward * 3000f);

				
		}

		ff = Input.GetAxis ("Fire2");

		if (ff > 0) {
			camoff.enabled = false;
			cam.enabled = true;
			can.enabled = true;
		} else {
			camoff.enabled = true;
			cam.enabled = false;
			can.enabled = false;
		}




	}

	void  OnCollisionEnter(Collision arg){
		
	}


}
