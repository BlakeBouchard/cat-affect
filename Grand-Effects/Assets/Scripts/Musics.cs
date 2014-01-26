using UnityEngine;
using System.Collections;

public class Musics : MonoBehaviour {

    private float waterMin;
    private float waterMax;
    private AudioSource waterMusic;
    GameObject waterObject;

	// Use this for initialization
	void Start () {

        waterObject = GameObject.Find("water");

        waterMin = waterObject.transform.position.y;
        waterMax = GameObject.Find("pipe").transform.position.y;

        AudioSource[] allMusic = gameObject.GetComponents<AudioSource>();

        for (int i = 0; i < allMusic.Length; i++)
        {
            if (allMusic[i].clip.name == "water_song")
            {
                waterMusic = allMusic[i];
            }
        }
        

	}
	
	// Update is called once per frame
	void Update () {
        waterMusic.volume = (waterObject.transform.position.y - waterMin) / (waterMax - waterMin);
	}
}
