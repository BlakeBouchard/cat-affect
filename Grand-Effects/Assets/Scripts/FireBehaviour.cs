using UnityEngine;
using System.Collections;

public class FireBehaviour : MonoBehaviour {

    GameObject kitty;
    CatFire catFire;

	public Transform target;

	// Use this for initialization
	void Start ()
    {
        kitty = GameObject.Find(target.name);
	    catFire = kitty.GetComponent<CatFire>();
	}
	
	// Update is called once per frame
	void Update ()
    {
	    
	}

    void OnTriggerEnter2D(Collider2D collider)
    {
		if (collider.gameObject == kitty) {
			catFire.MakeCatCry ();
		}

		if ((collider.gameObject == kitty) && !catFire.IsCatOnFire ()) {
			catFire.LightCatOnFire ();
		}
	}
	
	void OnTriggerExit2D(Collider2D collider)
	{
		if (collider.gameObject == kitty)
		{
			catFire.resetCat();
		}
	}
}
