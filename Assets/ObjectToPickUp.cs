using UnityEngine;
using System.Collections;

public class ObjectToPickUp : MonoBehaviour {

	public string type;

	void Start () {
	
	}

	void Update () {
	
	}

	void OnTriggerEnter(Collider other) {
		Inventory inventoryToAddObjectTo = other.gameObject.GetComponent<Inventory> ();

		bool colliderHasAnInventory = inventoryToAddObjectTo != null;

		if(colliderHasAnInventory){
			inventoryToAddObjectTo.AddToInventory(this);
		}
		 
	}
}
