using UnityEngine;
using System.Collections;

public class WoodBurning : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

    void Update()
    {
        Animator animator = GetComponent<Animator>();

        GameObject kitty = GameObject.Find("Kitty");

        if (kitty.GetComponent<CatFire>().isOnFire)
        {
            animator.SetBool("isBurnt", true);
            //audio.Play();
            GetComponent<BoxCollider2D>().enabled = false;
        }
    }
}
