using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class play : MonoBehaviour {
	private Animation anim;
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animation> ();
	}
	
	// Update is called once per frame
	void Update () {
		anim.Play("attack1");
	}
}
