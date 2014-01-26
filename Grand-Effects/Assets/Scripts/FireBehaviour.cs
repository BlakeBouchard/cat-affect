using UnityEngine;
using System.Collections;

public class FireBehaviour : MonoBehaviour {

    GameObject kitty;
    CatFire catFire;

	// Use this for initialization
	void Start ()
    {
        kitty = GameObject.Find("Kitty");
	    catFire = kitty.GetComponent<CatFire>();
	}
	
	// Update is called once per frame
	void Update ()
    {
	    
	}

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject == kitty && !catFire.IsCatOnFire())
        {
            catFire.LightCatOnFire();
        }
    }
}
