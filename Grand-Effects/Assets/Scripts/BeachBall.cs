using UnityEngine;
using System.Collections;

public class BeachBall : MonoBehaviour {

    Animator animator;
    bool ballIsPopped = false;

	// Use this for initialization
	void Start () {
        animator = GetComponent<Animator>();
	}

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.name == "Kitty" && !ballIsPopped)
        {
            animator.SetBool("isPopped", true);
            Debug.Log("Ball popped");
            ballIsPopped = true;
            audio.Play();
        }
    }

    void PopBeachBall()
    {

    }

	// Update is called once per frame
	void Update () {
	
	}
}
