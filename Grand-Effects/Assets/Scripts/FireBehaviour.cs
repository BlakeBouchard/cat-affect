using UnityEngine;
using System.Collections;

public class FireBehaviour : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
	    
	}

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.name == "Kitty")
        {
            Debug.Log("YOU KILLED THE KITTY");
            audio.Play();
        }
    }
}
