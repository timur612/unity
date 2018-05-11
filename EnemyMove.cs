using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMove : MonoBehaviour {
	NavMeshAgent nav;
	public Transform target;
	Animator anim;
	float f;
	Collider cl;

	// Use this for initialization
	void Start () {
		nav = GetComponent<NavMeshAgent> ();
		anim = GetComponent<Animator> ();
		cl = GetComponent<Collider> ();
	}
	
	// Update is called once per frame
	void Update () {
		f = Input.GetAxis ("Fire1");
		nav.SetDestination (target.position);
	}

	void OnCollisionEnter(Collision arg){
		if (arg.gameObject.tag=="bullet") {
			anim.SetFloat ("dead", 1.5f);
			nav.enabled = false;
			cl.enabled = false;

		}

		if (arg.gameObject.tag == "MainCamera") {
			Destroy (arg.gameObject);
		}
	}
}
