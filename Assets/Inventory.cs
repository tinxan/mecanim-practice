using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Inventory : MonoBehaviour
{

		Dictionary<ObjectToPickUp, int> objectsWithQuantityInInventory = new Dictionary<ObjectToPickUp, int> ();

		public void AddToInventory (ObjectToPickUp objectToPickUp)
		{

				bool objectAlreadyInInventory = objectsWithQuantityInInventory.ContainsKey (objectToPickUp);

				if (objectAlreadyInInventory) {
						objectsWithQuantityInInventory [objectToPickUp]++;
				} else {
						objectsWithQuantityInInventory.Add (objectToPickUp, 1);
				}

		print ("inventory");
				foreach (KeyValuePair<ObjectToPickUp, int> keyValuePair in objectsWithQuantityInInventory) {
						string inventoryObejctName = keyValuePair.Key.type;
						int quantity = keyValuePair.Value;

						print (inventoryObejctName + " " + quantity);
				}
		}


		// Use this for initialization
		void Start ()
		{
	
		}
	
		// Update is called once per frame
		void Update ()
		{
	
		}
}
