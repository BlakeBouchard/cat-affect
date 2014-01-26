using UnityEngine;
using System.Collections;

public class BeachBall : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.name == "Kitty")
        {
            animation.Play();
        }
    }

	// Update is called once per frame
	void Update () {
	
	}
}
