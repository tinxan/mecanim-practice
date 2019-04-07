using UnityEngine;
using System.Collections;

public class GoToTarget : MonoBehaviour {


	public GameObject target;

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<UnityEngine.AI.NavMeshAgent>().destination=target.transform.position;
	}
}
