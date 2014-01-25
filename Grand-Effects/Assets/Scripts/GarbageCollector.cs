using UnityEngine;
using System.Collections;

public class GarbageCollector : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    // Destroy something as it enters the world boundary
    void OnTriggerEnter2D(Collider2D collider) {
        Debug.Log("Killed something called: " + collider.gameObject.name);
        Destroy(collider);
    }
}
