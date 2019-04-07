using UnityEngine;
using System.Collections;

public class Watever : MonoBehaviour {

	public float Horizontal { get{ return Input.GetAxis ("Horizontal");} }
	public float Vertical { get{ return Input.GetAxis ("Vertical") * Multiplier;} }


	public float Multiplier {
		get{
			if(Input.GetKey (KeyCode.LeftShift))
				return 2.0f;
			else
				return 1.0f;
		}
				
		}

	private Animator animator;

	void Start(){
		animator = GetComponent<Animator> ();

	}

	void Update () {


		animator.SetFloat ("speed", Vertical);
		animator.SetFloat ("direction", Horizontal);
		//animator.SetBool ("dying", true);
	}
}
