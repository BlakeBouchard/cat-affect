using UnityEngine;
using System.Collections;

public class CatFire : MonoBehaviour {

    public bool isOnFire = false;
	public bool fireTest = false;

//	public float timer;

	public AudioClip sound1;

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
    }

	public void CatNotOnFire()
	{
		isOnFire = false;
	}

	public void MakeCatCry()
	{
		if (fireTest == false) {
			audio.PlayOneShot(sound1);
		}
		fireTest = true;
	}

	public void resetCat()
	{
		fireTest = false;
		Debug.Log ("RAWR");
	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}
}
