using UnityEngine;
using System.Collections;

public class FireBehaviour : MonoBehaviour {

    GameObject kitty;
	GameObject fire;
    CatFire catFire;

	public Transform targetCat;
	public Transform targetFire;

	// Use this for initialization
	void Start ()
    {
        kitty = GameObject.Find(targetCat.name);
		fire = GameObject.Find (targetFire.name);

	    catFire = kitty.GetComponent<CatFire>();
	}
	
	// Update is called once per frame
	void Update ()
    {
		if (kitty.GetComponent<PlayerControl>().isSwimming == true) {
			fire.renderer.enabled = false;
			catFire.CatNotOnFire();
		}
	}

    void OnTriggerEnter2D(Collider2D collider)
    {
		if (collider.gameObject == kitty) {
			catFire.MakeCatCry ();
		}

		if ((collider.gameObject == kitty) && !catFire.IsCatOnFire ()) {
			catFire.LightCatOnFire ();
			fire.renderer.enabled = true;
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
