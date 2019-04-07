using UnityEngine;
using System.Collections;

public class FollowAda : MonoBehaviour {

	public GameObject ada;
	

	void Update () {
		transform.LookAt (ada.transform.position);
	}
}
