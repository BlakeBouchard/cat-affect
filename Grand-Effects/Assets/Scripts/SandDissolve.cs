using UnityEngine;
using System.Collections;

public class SandDissolve : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
	
	void Update()
    {
        Animator animator = GetComponent<Animator>();

        GameObject water = GameObject.Find("water");

        if (water.GetComponent<BoxCollider2D>().size.y + water.transform.position.y >= gameObject.transform.position.y + 4 && animator.GetBool("isDissolved") == false)
        {
            animator.SetBool("isDissolved", true);
            collider2D.enabled = false;
            audio.Play();
        }
	}
}
