using UnityEngine;
using System.Collections;

public class BeachBall : MonoBehaviour {

    Animator animator;
    bool ballIsPopped = false;
    GameScreens gameScreens;

	// Use this for initialization
	void Start () {
        animator = GetComponent<Animator>();
        gameScreens = GameObject.Find("Main Camera").GetComponent<GameScreens>();
	}

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.name == "Kitty" && !ballIsPopped)
        {
            PopBeachBall();
        }
    }

    void PopBeachBall()
    {
        animator.SetBool("isPopped", true);
        Debug.Log("Ball popped");
        ballIsPopped = true;
        audio.Play();
        gameScreens.levelComplete();
    }

	// Update is called once per frame
	void Update () {
	
	}
}
