using UnityEngine;
using System.Collections;

public class CatFire : MonoBehaviour {

    public bool isOnFire = false;

	// Use this for initialization
	void Start ()
    {
	
	}

    public bool IsCatOnFire()
    {
        return isOnFire;
    }

    public void LightCatOnFire()
    {
        isOnFire = true;
        Debug.Log("YOU KILLED THE KITTY");
        audio.Play();
    }
	
	// Update is called once per frame
	void Update ()
    {
	
	}
}
